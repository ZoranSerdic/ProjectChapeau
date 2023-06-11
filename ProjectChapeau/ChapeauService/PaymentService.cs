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

        public void CreateBill(Bill bill)
        {
            paymentDAO.CreateBill(bill);
        }

        public int GetCurrentBillId()
        {
            return paymentDAO.GetCurrentBillId();
        }
        public void CloseBill(Bill bill)
        {
            paymentDAO.CloseBill(bill); 
        }
        public bool CheckForOpenBill(Table table)
        {
            return paymentDAO.CheckForOpenBill(table);
        }
        public Bill GetOpenBill(Table table)
        {
            return paymentDAO.GetOpenBill(table);
        }
        public void DeleteActiveBill(Table table)
        {
            paymentDAO.DeleteActiveBill(table);
        }
        public void DeleteActivePayments(Bill bill)
        {
            paymentDAO.DeleteActivePayments(bill);
        }
        public void UpdateBillTipAmount(Bill bill)
        {
            paymentDAO.UpdateBillTipAmount(bill);
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
        public void UpdateTableStatusToFree(Table table)
        {
            paymentDAO.UpdateTableStatusToFree(table);
        }
    }
}
