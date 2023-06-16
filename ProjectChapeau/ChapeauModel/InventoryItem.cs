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
        public int InStock { get; set; }
        public int MenuItemID { get; set; }     
    }
}
