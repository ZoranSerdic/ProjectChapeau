using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Occupation
    {
        public int OccupationId { get; set; }   

        public OccupationName Name { get; set; }

        public enum OccupationName { Waiter, Chef, Bartender, Manager }
    }
}
