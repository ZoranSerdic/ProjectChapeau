using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDAO orderDAO;
        public OrderService()
        {
            orderDAO = new OrderDAO();
        }

        public List<Order> GetOrders(FoodType[] foodType, OrderedItemStatus[] status)
        {
            return orderDAO.GetOrders(foodType, status);
        }
    }
}
