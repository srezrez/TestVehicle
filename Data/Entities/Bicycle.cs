using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Bicycle : Vehicle
    {
        public readonly int speedsAmount;

        public Bicycle() : base("LTD", "km34")
        {
            speedsAmount= 5;
        }
    }
}
