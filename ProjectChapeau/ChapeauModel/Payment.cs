using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BillId { get; set; }
        public PaymentMethod Method { get; set; }
        public decimal Amount { get; set; }
        public decimal Tip { get; set; }

        public Payment(int paymentId, int billId, PaymentMethod method, decimal amount, decimal tip)
        {
            PaymentId = paymentId;
            BillId = billId;
            Method = method;
            Amount = amount;
            Tip = tip;
        }
    }
}
