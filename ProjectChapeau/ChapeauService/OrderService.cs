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

        public List<Order> GetUnpreparedOrdersByFoodType(FoodType foodType)
        {
            return orderDAO.GetUnpreparedOrdersByFoodType(foodType);
        }

        public List<Order> GetReadyDrinks()
        {
            return orderDAO.GetReadyDrinks();
        }

        public List<Order> GetReadyFood()
        {
            return orderDAO.GetReadyFood();
        }
    }
}
