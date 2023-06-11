using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public MenuItem MenuItem { get; set; }
        public string? Comment { get; set; }
        public int Amount { get; set; }
        public OrderedItemStatus Status { get; set; }
        public DateTime? PreparedAt { get; set; }    
    }
}
