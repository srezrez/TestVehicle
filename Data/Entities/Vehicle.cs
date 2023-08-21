using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public abstract class Vehicle
    {
        public readonly string Brand;
        public readonly string Model;
        public Vehicle() {}
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
