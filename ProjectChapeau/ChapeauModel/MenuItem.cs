﻿using System;
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

        public double Price { get; set; }

        public float Vat { get; set; } 
        public FoodType CourseType { get; set; }

        public List<InventoryItem> Ingredients { get; set; }

        public MenuItem(int menuItemId, string name, double price, float vat)
        {
            MenuItemId = menuItemId;
            Name = name;
            Price = price;
            Vat = vat;
            Ingredients = new List<InventoryItem>();
        }
    }
}
