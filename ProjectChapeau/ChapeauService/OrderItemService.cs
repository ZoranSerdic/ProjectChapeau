using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class OrderItemService
    {
        private OrderItemDAO orderItemDAO;
        public OrderItemService()
        {
            orderItemDAO = new OrderItemDAO();
        }

        public void UpdateOrderItemStatus(OrderItem orderItem)
        {
            orderItemDAO.UpdateOrderItemStatus(orderItem);
        }

        public int CreateOrder(Order order)
        {
            int orderId = orderItemDAO.CreateOrder(order);
            return orderId;
        }

        public void AddOrderItem(OrderItem orderItem) 
        { 
            orderItemDAO.AddOrderItem(orderItem);
        }
    }
}
