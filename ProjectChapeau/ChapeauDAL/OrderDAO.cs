using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

        public List<Order> GetUnpreparedOrdersByFoodType(FoodType foodType)
        {
            List<Order> drinkOrders = new List<Order>();

            string query = @"SELECT o.orderId, o.tableId, o.time, o.isPayed, o.employeeId, oi.consistsOfId, mi.courseType
                            FROM [Order] AS o
                            INNER JOIN ConsistsOf AS oi ON o.orderId = oi.orderId
                            INNER JOIN MenuItem AS mi ON oi.menuItemId = mi.menuItemId
                            WHERE mi.courseType = @courseType
                            AND(oi.status = @statusOne OR oi.status = @statusTwo)";

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@courseType", foodType.ToString());
            sqlParameters[1] = new SqlParameter("@statusOne", OrderedItemStatus.Sent.ToString());
            sqlParameters[2] = new SqlParameter("@statusTwo", OrderedItemStatus.Preparing.ToString());

            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetReadyDrinks()
        {
            List<Order> drinkOrders = new List<Order>();

            string query = @"SELECT o.orderId, o.tableId, o.time, o.isPayed, o.employeeId, oi.consistsOfId, oi.preparedAt, mi.courseType
                            FROM [Order] AS o
                            INNER JOIN ConsistsOf AS oi ON o.orderId = oi.orderId
                            INNER JOIN MenuItem AS mi ON oi.menuItemId = mi.menuItemId
                            WHERE mi.courseType = @courseType  
                            AND oi.status = @status
                            AND CONVERT(date, o.time) = CONVERT(date, GETDATE())
                            ORDER BY oi.preparedAt DESC";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@courseType", FoodType.Drink.ToString());
            sqlParameters[1] = new SqlParameter("@status", OrderedItemStatus.Ready.ToString());
           
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetReadyFood()
        {
            List<Order> readyFood = new List<Order>();

            string query = @"SELECT o.orderId, o.tableId, o.time, o.isPayed, o.employeeId, oi.consistsOfId, oi.preparedAt, mi.courseType
                    FROM [Order] AS o
                    INNER JOIN ConsistsOf AS oi ON o.orderId = oi.orderId
                    INNER JOIN MenuItem AS mi ON oi.menuItemId = mi.menuItemId
                    WHERE mi.courseType IN (@courseTypeStarters, @courseTypeMains, @courseTypeDesserts)
                    AND oi.status = @status
                    AND CONVERT(date, o.time) = CONVERT(date, GETDATE())
                    ORDER BY oi.preparedAt DESC";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@courseTypeStarters", FoodType.Starter.ToString());
            sqlParameters[1] = new SqlParameter("@courseTypeMains", FoodType.MainCourse.ToString());
            sqlParameters[2] = new SqlParameter("@courseTypeDesserts", FoodType.Dessert.ToString());
            sqlParameters[3] = new SqlParameter("@status", OrderedItemStatus.Ready.ToString());

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            readyFood = ReadOrders(dataTable);

            return readyFood;
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                int orderId = (int)dataRow["orderId"];
                bool orderExists = false;
                Order order = null;

                foreach (Order existingOrder in orders) // check if the order with the id already exists
                {
                    if (existingOrder.OrderId == orderId)
                    {
                        orderExists = true;
                        order = existingOrder;
                        break;
                    }
                }   
                if (!orderExists)  // if ot doesn't exist , the new order is created
                {
                    order = new Order
                    {
                        OrderId = orderId,
                        Table = tableDAO.GetTableById((int)dataRow["tableId"]),
                        Time = (DateTime)dataRow["time"],
                        IsPaid = (bool)dataRow["isPayed"],
                        Employee = employeeDAO.GetEmployeeById((int)dataRow["employeeId"]),
                        OrderedItems = new List<OrderItem>()
                    };
                    orders.Add(order);
                }
                OrderItem orderItem = orderItemDAO.GetOrderItemById((int)dataRow["consistsOfId"]);
                order.OrderedItems.Add(orderItem);  // add the item to the order
            }
            return orders;
        }
    }
}
