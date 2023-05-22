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
        public status Status { get; set; }
        public int Number { get; set; }

        public enum status { Free, Occupied, Reserved }
    }
}
