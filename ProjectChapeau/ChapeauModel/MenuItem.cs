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
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Vat { get; set; } 
        public FoodType? CourseType { get; set; }
        public MenuType? MenuType { get; set; }

        
    }
}
