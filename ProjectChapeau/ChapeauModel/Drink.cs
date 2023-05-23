using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Drink : MenuItem
    {
        public bool IsAlcoholic { get; set; }

        public Drink(int menuItemId, string name, double price, float vat, bool isAlcoholic) : base(menuItemId, name, price, vat)
        {
            IsAlcoholic = isAlcoholic;
        }
    }
}
