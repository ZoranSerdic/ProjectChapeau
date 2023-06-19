using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDAO
    {
        private EmployeeDAO employeeDAO;
        private TableDAO tableDAO;
        private OrderItemDAO orderItemDAO;

        public OrderDAO()
        {
            employeeDAO = new EmployeeDAO();
            tableDAO = new TableDAO();
            orderItemDAO = new OrderItemDAO();
        }

        #region Mariia
        public List<Order> GetOrders(FoodType[] foodType, OrderedItemStatus[] status) // gets orders depending on the type and status
        {
            try
            {
                string query = @"SELECT o.orderId, o.tableId, o.time, o.isPayed, o.employeeId, oI.consistsOfId, oI.preparedAt
                            FROM [Order] AS o
                            INNER JOIN ConsistsOf AS oI ON o.orderId = oI.orderId
                            INNER JOIN MenuItem AS mI ON oI.menuItemId = mI.menuItemId 
                            WHERE CONVERT(date, o.time) = CONVERT(date, DATEADD(hour, 2, GETUTCDATE()))";  //shows today's orders only             

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                if (foodType.Length == 1) // used for drinks/starters/mains/desserts (for bar and kitchen view and for bar history view)
                {
                    query += @" AND mI.courseType = @courseType ";
                    sqlParameters.Add(new SqlParameter("@courseType", foodType[0].ToString()));
                }
                else if (foodType.Length == 3) // used for starters and mains and desserts at the same time (for kitchen history)
                {
                    query += @"AND mI.courseType IN (@courseTypeStarters, @courseTypeMains, @courseTypeDesserts) ";
                    sqlParameters.Add(new SqlParameter("@courseTypeStarters", foodType[0].ToString()));
                    sqlParameters.Add(new SqlParameter("@courseTypeMains", foodType[1].ToString()));
                    sqlParameters.Add(new SqlParameter("@courseTypeDesserts", foodType[2].ToString()));
                }
                if (status.Length == 1) // used for ready items - display history
                {
                    query += @"AND oI.status = @statusReady
                            ORDER BY oI.preparedAt DESC";// time when the items were prepared is in descending order
                    sqlParameters.Add(new SqlParameter("@statusReady", status[0].ToString()));
                }
                else if (status.Length == 2) // used for items which were sent from the waiter and in process of preparation
                {
                    query += "AND (oI.status = @statusSent OR oI.status = @statusPreparing)";
                    sqlParameters.Add(new SqlParameter("@statusSent", status[0].ToString()));
                    sqlParameters.Add(new SqlParameter("@statusPreparing", status[1].ToString()));
                }
                return ReadOrders(ExecuteSelectQuery(query, sqlParameters.ToArray()));
            }
            catch (Exception)
            {
                throw;
            }     
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Order order = new Order();
                int orderId = (int)dataRow["orderId"];

                bool orderExists = false;
                foreach (Order existingOrder in orders) // check if the order with the id already exists
                {
                    if (existingOrder.OrderId == orderId)
                    {
                        orderExists = true;
                        order = existingOrder;
                        break;
                    }
                }
                if (!orderExists)  // if it doesn't exist , the new order is made, else - the orderedItem is added to the list of orderedItem to the existing order
                {
                    order.OrderId = orderId;
                    order.Table = tableDAO.GetTableById((int)dataRow["tableId"]);
                    order.Time = (DateTime)dataRow["time"];
                    order.IsPaid = (bool)dataRow["isPayed"];
                    order.Employee = employeeDAO.GetEmployeeById((int)dataRow["employeeId"]);
                    order.OrderedItems = new List<OrderItem>();

                    orders.Add(order); // the order is added to the list with orders
                };

                OrderItem orderItem = orderItemDAO.GetOrderItemById((int)dataRow["consistsOfId"]); // gets the ordered item
                order.OrderedItems.Add(orderItem);  // add the item to the order
            }
            return orders;
        }
        #endregion
        #region Zoran
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
                orderId = ExecuteScalarEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }

            return orderId;
        }
        #endregion

        public List<Order> GetUnpaidOrdersByTableId(int tableId)
        {
            string query = @"SELECT o.orderId, o.tableId, o.time, o.isPayed, o.employeeId, oI.consistsOfId, oI.preparedAt
                    FROM [Order] AS o
                    INNER JOIN ConsistsOf AS oI ON o.orderId = oI.orderId
                    WHERE o.tableId = @tableId AND o.isPayed = 0";

            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@tableId", tableId)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters.ToArray());
            return ReadOrders(dataTable);
        }

        public void UpdateOrderPaidStatus(Table table)
        {
            string query = "UPDATE [Order] SET isPayed = 1 WHERE tableId = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableId);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            string query = "UPDATE ConsistsOf SET status = @newStatus WHERE consistsOfId = @consistsOfId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@newStatus", newStatus);
            sqlParameters[1] = new SqlParameter("@consistsOfId", orderId);

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
