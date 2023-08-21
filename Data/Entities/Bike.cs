using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Bike : Vehicle
    {
        public readonly string BikeType;

        public Bike() : base("Java", "m56")
        {
            BikeType = "Simple";
        }
    }
}
