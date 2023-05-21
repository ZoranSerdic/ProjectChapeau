using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Vat
    {
        public int VatId { get; set; }

        public double VatAmount { get; set; }

        public Vat(int vatId, double vatAmount)
        {
            VatId = vatId;
            VatAmount = vatAmount;
        }
    }
}
