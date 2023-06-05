using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Table
    {
        public int TableId { get; set; }
        public TableStatus Status { get; set; }

        //public int Number { get; set; } // do we need a table number if we already have a tableId?
    }
}
