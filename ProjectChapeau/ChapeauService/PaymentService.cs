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
            paymentDAO= new PaymentDAO();
        }

        public void GenerateBill(Bill bill)
        {
            paymentDAO.GenerateBill(bill);
        }

        public int GetCurrentBillId()
        {
            return paymentDAO.GetCurrentBillId();
        }

        public List<OrderItem> GetAllItemsFromActiveOrders(Table table)
        {
            return paymentDAO.GetAllItemsFromActiveOrders(table);
        }

        public void AddPayment(Payment payment)
        {
            paymentDAO.AddPayment(payment);
        }
        public void AddPayments(List<Payment> payments)
        {
            foreach (Payment payment in payments)
            {
                paymentDAO.AddPayment(payment);
            }
        }
        public void UpdateOrderPaidStatus(Table table)
        {
            paymentDAO.UpdateOrderPaidStatus(table);
        }
    }
}
