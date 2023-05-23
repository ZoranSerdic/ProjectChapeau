using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;

namespace ChapeauService
{
    public class PaymentService
    {
        PaymentDAO paymentDAO;

        public PaymentService()
        {
            paymentDAO= new PaymentDAO();
        }

        public void GenerateBill(int tableId, decimal totalAmount)
        {
            paymentDAO.CreateBill(tableId, totalAmount);
        }

        public int GetCurrentBillId()
        {
            return paymentDAO.GetCurrentBillId();
        }
    }
}
