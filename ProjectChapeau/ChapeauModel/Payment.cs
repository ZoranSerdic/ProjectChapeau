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
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public decimal Tip { get; set; }
    }
}
