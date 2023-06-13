using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class PaymentService
    {
        PaymentDAO paymentDAO;

        public PaymentService()
        {
            paymentDAO = new PaymentDAO();
        }
        public void DeleteActivePayments(Bill bill)
        {
            paymentDAO.DeleteActivePayments(bill);
        }
        public List<Payment> GetActivePayments(Bill bill)
        {
            return paymentDAO.GetActivePayments(bill);
        }
        public List<OrderItem> GetAllItemsFromActiveOrders(Table table)
        {
            return paymentDAO.GetAllItemsFromActiveOrders(table);
        }
        public void AddPayment(Payment payment)
        {
            paymentDAO.AddPayment(payment);
        }
    }
}
