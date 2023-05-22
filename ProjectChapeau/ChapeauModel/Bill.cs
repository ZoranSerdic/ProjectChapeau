using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Bill
    {
        public int BillId { get; set; }
        public Table Table { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTip { get; set; }
        public bool IsPaid { get; set; }
        public DateTime date { get; set; }
    }
}
