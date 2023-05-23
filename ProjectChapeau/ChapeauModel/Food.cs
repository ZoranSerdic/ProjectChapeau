using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Food : MenuItem
    {

        public MenuType MenuTime { get; set; }

        public Food(int menuItemId, string name, double price, float vat, MenuType MenuTime) : base(menuItemId, name, price, vat)
        {
            this.MenuTime = MenuTime;
        }

        
    }
}

