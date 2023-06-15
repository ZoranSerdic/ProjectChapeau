using ChapeauModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ChapeauDAL
{
    public class OrderItemDAO : BaseDAO
    {
        private MenuItemDAO menuItemDAO;

        public OrderItemDAO()
        {
            menuItemDAO = new MenuItemDAO();
        }

        #region Mariia
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
            throw new Exception($"Order item with the {orderItemId} id was not found!");
        }

        private OrderItem ReadOrderItem(DataRow dataRow)
        {
            OrderItem orderItem = new OrderItem()
            {
                OrderItemId = (int)dataRow["consistsOfId"],
                MenuItem = menuItemDAO.GetMenuItemById((int)dataRow["menuItemId"]),
                Amount = (int)dataRow["amount"],
                Comment = dataRow["comment"] == DBNull.Value ? string.Empty : (string)dataRow["comment"], // if its null in the database it will become empty string in orderItem
                Status = (OrderedItemStatus)Enum.Parse(typeof(OrderedItemStatus), dataRow["status"].ToString(), ignoreCase: true),
                PreparedAt = dataRow["preparedAt"] == DBNull.Value ? null : (DateTime)dataRow["preparedAt"] // untill the orderItem is prepared the time preparedAt is null
            };
            return orderItem;
        }

        public void UpdateOrderItemStatus(OrderItem orderItem)
        {
            string query = @"UPDATE ConsistsOf
                            SET status = @Status";

            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@Status", orderItem.Status.ToString()), 
                new SqlParameter("@Id", orderItem.OrderItemId)
            };

            // if the item is ready then the preparedAt time is added as well
            if (orderItem.Status == OrderedItemStatus.Ready)
            {
                query += ", preparedAt = @PreparedAt";
                sqlParameters.Add(new SqlParameter("@PreparedAt", orderItem.PreparedAt));
            };
            query += " WHERE consistsOfId = @Id";  // add the query

            ExecuteEditQuery(query, sqlParameters.ToArray());
        }
        #endregion

        public int CreateOrder(Order order)
        {
            int orderId = 0;

            try
            {
                // This method creates the Order in the database
                string query = "INSERT INTO [Order] (tableId, time, employeeId, isPayed)" +
                    "VALUES (@tableId, @time, @employeeId, @isPayed);" +
                    "SELECT SCOPE_IDENTITY();";

                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter("@tableId", order.Table.TableId);
                sqlParameters[1] = new SqlParameter("@time", order.Time);
                sqlParameters[2] = new SqlParameter("@employeeId", order.Employee.EmployeeId);
                sqlParameters[3] = new SqlParameter("@isPayed", order.IsPaid);
                ExecuteEditQuery(query, sqlParameters);

                orderId = ExecuteScalarEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }

            return orderId;
        }

        public void AddOrderItem(OrderItem item)
        {
            try
            {
                // This method adds an OrderItem(ConsistsOf) in Order
                string query = "INSERT INTO ConsistsOf (orderId, menuItemId, comment, amount, status, preparedAt) " +
                    "VALUES (@orderId, @menuItemId, @comment, @amount, @status, @preparedAt);";
                SqlParameter[] sqlParameters = new SqlParameter[6];
                sqlParameters[0] = new SqlParameter("@orderId", item.OrderItemId);
                sqlParameters[1] = new SqlParameter("@menuItemId", item.MenuItem.MenuItemId);
                sqlParameters[2] = new SqlParameter("@comment", item.Comment);
                sqlParameters[3] = new SqlParameter("@amount", item.Amount);
                sqlParameters[4] = new SqlParameter("@status", item.Status.ToString());
                sqlParameters[5] = new SqlParameter("@preparedAt", DBNull.Value);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
