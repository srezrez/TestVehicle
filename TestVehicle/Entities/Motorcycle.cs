using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestVehicle.Const;

namespace TestVehicle.Entities
{
    public class Motorcycle : Vehicle
    {
        public string Type { get; }

        public Motorcycle() : base(MotorcycleBrand, MotorcycleModel)
        {
            Type = MotorcycleType;
        }
    }
}
