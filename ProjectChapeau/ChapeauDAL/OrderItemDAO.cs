using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderItemDAO : BaseDAO
    {
        private MenuItemDAO menuItemDAO;

        public OrderItemDAO()
        {
            menuItemDAO = new MenuItemDAO();
        }
        public OrderItem GetOrderItemById(int orderItemId)
        {
            string query = @"SELECT consistsOfId, menuItemId, comment, amount, status, preparedAt
                            FROM ConsistsOf
                            WHERE consistsOfId = @OrderItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderItemId", orderItemId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            if (dataTable.Rows.Count > 0) 
            {
                DataRow dataRow = dataTable.Rows[0];
                OrderItem orderItem = ReadOrderItem(dataRow);
                return orderItem;
            }
            return null; // item with the given id is not found
        }

        private OrderItem ReadOrderItem(DataRow dataRow)
        {
            OrderItem orderItem = new OrderItem()
            {
                OrderItemId = (int)dataRow["consistsOfId"],
                MenuItem = menuItemDAO.GetMenuItemById((int)dataRow["menuItemId"]), // what if it returns null?
                Amount = (int)dataRow["amount"],
                Comment = dataRow["comment"] == DBNull.Value ? string.Empty : (string)dataRow["comment"],
                Status = (OrderedItemStatus)Enum.Parse(typeof(OrderedItemStatus), dataRow["status"].ToString(), ignoreCase: true),
                PreparedAt = dataRow["preparedAt"] == DBNull.Value ? null : (DateTime)dataRow["preparedAt"] // preparedAt can be null
            };
            return orderItem;
        }

        public void UpdateOrderItemStatus(OrderItem orderItem)
        {
            string query = @"UPDATE ConsistsOf
                            SET status = @Status";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Status", orderItem.Status.ToString()),
                new SqlParameter("@Id", orderItem.OrderItemId)
            };

            // if the item is ready then the preparedAt time is added as well
            if (orderItem.Status == OrderedItemStatus.Ready)
            {
                query += ", preparedAt = @PreparedAt";
                parameters.Add(new SqlParameter("@PreparedAt", orderItem.PreparedAt));
            };
            query += " WHERE consistsOfId = @Id";  
            SqlParameter[] sqlParameters = parameters.ToArray();

            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddOrder(OrderItem item)
        {
            //this method adds the item into the menu Item table 
            string query = "INSERT INTO dbo.ConsistOf (orderId, menuItemId, comment, amount, status, preparedAt) " +
                "VALUES (@orderId, @menuItemId, @comment, @amount, @status, @preparedAt);";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@orderId", item.OrderItemId);
            sqlParameters[1] = new SqlParameter("@menuItemId", item.MenuItem);
            sqlParameters[2] = new SqlParameter("@comment", item.Comment);
            sqlParameters[3] = new SqlParameter("@amount", item.Amount);
            sqlParameters[4] = new SqlParameter("@status", item.Status);
            sqlParameters[5] = new SqlParameter("@preparedAt", item.PreparedAt);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
