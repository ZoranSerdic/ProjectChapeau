using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        // public List<MenuItem> Items { get; set; } - should InventoryItem class/object have a list of menu items which have this inventoryItem as an ingredient?

        public InventoryItem(int inventoryItemId, string name, double price, int inStock)
        {
            InventoryItemId = inventoryItemId;
            Name = name;
            Price = price;
            InStock = inStock;
            //Items = new List<MenuItem>();
        }
    }
}
