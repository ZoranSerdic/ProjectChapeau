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

        public List<Order> GetUnpreparedDrinks()
        {
            return orderDAO.GetUnpreparedDrinks();    
        }

        public List<Order> GetUnpreparedStarters()
        {
            return orderDAO.GetUnpreparedStarters();
        }

        public List<Order> GetUnpreparedMains()
        {
            return orderDAO.GetUnpreparedMains();
        }
        public List<Order> GetUnpreparedDesserts()
        {
            return orderDAO.GetUnpreparedDesserts();
        }

        public List<Order> GetReadyDrinks()
        {
            return orderDAO.GetReadyDrinks();
        }

        public List<Order> GetReadyStarters()
        {
            return orderDAO.GetReadyStarters();
        }

        public List<Order> GetReadyMains()
        {
            return orderDAO.GetReadyMains();
        }
        public List<Order> GetReadyDesserts()
        {
            return orderDAO.GetReadyDesserts();
        }

    }
}
