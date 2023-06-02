using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = @"SELECT consistsOfId, menuItemId, comment, amount, status
                            FROM ConsistsOf
                            WHERE consistsOfId = @OrderItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderItemid",orderItemId);

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
                Status = (OrderedItemStatus)Enum.Parse(typeof(OrderedItemStatus), dataRow["status"].ToString(), ignoreCase: true)
            };
            return orderItem;
        }

    }
}
