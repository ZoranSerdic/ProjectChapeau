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

        public string Comment { get; set; }

        public int Amount { get; set; }

        public OrderedItemStatus Status { get; set; }

        public OrderItem(int orderItemId, MenuItem menuItem, int amount)
        {
            OrderItemId = orderItemId;
            MenuItem = menuItem;
            Amount = amount;
        }
        public enum OrderedItemStatus { Sent, Preparing, Ready } //?sent? which statuses do we havedo we need "served"??
    }
}
