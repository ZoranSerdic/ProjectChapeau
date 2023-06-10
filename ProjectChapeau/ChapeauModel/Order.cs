using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public Table Table { get; set; }
        public DateTime Time { get; set; }
        public bool IsPaid { get; set; }
        public Employee Employee { get; set; }
        public List<OrderItem> OrderedItems { get; set; }

        public Order()
        {
            
        }
    }
}
