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

        public occupationName Name { get; set; }

        public enum occupationName { Waiter, Chef, Bartender, Manager }
    }
}
