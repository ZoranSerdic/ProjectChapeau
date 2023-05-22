using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Food
    {
        public foodType Type { get; set; }

        public menuTime MenuTime { get; set; }

        public Food(int menuItemId, string name, double price, Vat vat, menuTime menuTime, foodType type) : base(menuItemId, name, price, vat)
        {
            MenuTime = menuTime;
            Type = type;
        }

        public enum menuTime { Lunch, Dinner }
        public enum foodType { Starter, MainCourse, Dessert }
    }
}

