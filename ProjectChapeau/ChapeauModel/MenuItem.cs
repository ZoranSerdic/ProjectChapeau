using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Vat { get; set; } 
        public FoodType? CourseType { get; set; }

        
        public MenuItem()
        {
            // a constructor without any parameters 
        }
        public MenuItem(int menuItemId, string name, decimal price, float vat)
        {
            MenuItemId = menuItemId;
            Name = name;
            Price = price;
            Vat = vat;
        }
    }
}
