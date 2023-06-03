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
            string query = @"SELECT consistsOfId, preparedAt, menuItemId, comment, amount, status
                            FROM ConsistsOf
                            WHERE consistsOfId = @OrderItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderItemid", orderItemId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                OrderItem orderItem = ReadOrderItem(dataRow);
                return orderItem;
            }
            return null; // Item not found
        }

        private OrderItem ReadOrderItem(DataRow dataRow)
        {
            OrderItem orderItem = new OrderItem()
            {
                OrderItemId = (int)dataRow["consistsOfId"],
                MenuItem = menuItemDAO.GetMenuItemById((int)dataRow["menuItemId"]),
                Amount = (int)dataRow["amount"],
                Comment = dataRow["comment"] == DBNull.Value ? string.Empty : (string)dataRow["comment"],
                Status = (OrderedItemStatus)Enum.Parse(typeof(OrderedItemStatus), dataRow["status"].ToString(), ignoreCase: true),
                PreparedAt = dataRow["preparedAt"] == DBNull.Value ? (DateTime?)null : (DateTime)dataRow["preparedAt"] // preparedAt can be null
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

            // if the item is ready then we also add the preparedAt time
            if (orderItem.Status == OrderedItemStatus.Ready)
            {
                query += ", preparedAt = @PreparedAt";
                parameters.Add(new SqlParameter("@PreparedAt", orderItem.PreparedAt));
            }; // is the item is ready we also add preparedAt time to the database

            query += " WHERE consistsOfId = @Id";
            
            SqlParameter[] sqlParameters = parameters.ToArray();

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
