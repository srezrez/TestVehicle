using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Car : Vehicle
    {
        public readonly int maxSpeed;

        public Car() : base("BMW", "a23")
        {
            maxSpeed= 150;
        }
    }
}
