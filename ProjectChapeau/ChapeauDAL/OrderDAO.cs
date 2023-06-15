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

        public List<Order> GetOrders(FoodType[] foodType, OrderedItemStatus[] status) // gets orders depending on the type and status
        {
            List<Order> orders = new List<Order>();

            string query = @"SELECT o.orderId, o.tableId, o.time, o.isPayed, o.employeeId, oI.consistsOfId, oI.preparedAt
                            FROM [Order] AS o
                            INNER JOIN ConsistsOf AS oI ON o.orderId = oI.orderId
                            INNER JOIN MenuItem AS mI ON oI.menuItemId = mI.menuItemId ";

            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if(foodType.Length == 1)
            {
                query += @"WHERE mI.courseType = @courseType
                           AND ";
                sqlParameters.Add(new SqlParameter("@courseType", foodType[0].ToString()));
            }
            else if(foodType.Length == 3)
            {
                query += @"WHERE mI.courseType IN (@courseTypeStarters, @courseTypeMains, @courseTypeDesserts)
                           AND ";
                sqlParameters.Add(new SqlParameter("@courseTypeStarters", foodType[0].ToString()));
                sqlParameters.Add(new SqlParameter("@courseTypeMains", foodType[1].ToString()));
                sqlParameters.Add(new SqlParameter("@courseTypeDesserts", foodType[2].ToString()));
            }
            if (status.Length == 1)
            {
                query += "oI.status = @statusReady";
                sqlParameters.Add(new SqlParameter("@statusReady", status[0].ToString()));
            }
            else if (status.Length == 2)
            {
                query += "(oI.status = @statusSent OR oI.status = @statusPreparing)";
                sqlParameters.Add(new SqlParameter("@statusSent", status[0].ToString()));
                sqlParameters.Add(new SqlParameter("@statusPreparing", status[1].ToString()));
            }
            query += " AND CONVERT(date, o.time) = CONVERT(date, DATEADD(hour, 2, GETUTCDATE()))";// -- shows today's orders only
            if (status.Length == 1)
                query += " ORDER BY oI.preparedAt DESC";

            return ReadOrders(ExecuteSelectQuery(query, sqlParameters.ToArray()));
        }
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

                if (!orderExists)  // if it doesn't exist , the new order is made
                {
                    order = new Order();    
                    order.OrderId = orderId;
                    order.Table = tableDAO.GetTableById((int)dataRow["tableId"]);
                    order.Time = (DateTime)dataRow["time"];
                    order.IsPaid = (bool)dataRow["isPayed"];
                    order.Employee = employeeDAO.GetEmployeeById((int)dataRow["employeeId"]);
                    order.OrderedItems = new List<OrderItem>();

                    orders.Add(order); // the order is added to the list with orders
                }; 

                OrderItem orderItem = orderItemDAO.GetOrderItemById((int)dataRow["consistsOfId"]);
                order.OrderedItems.Add(orderItem);  // add the item to the order
            }
            return orders;
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
