using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestVehicle.Const;

namespace TestVehicle.Entities
{
    public class Car : Vehicle
    {
        public int MaxSpeed { get; }

        public Car() : base(CarBrand, CarModel)
        {
            MaxSpeed = CarMaxSpeed;
        }
    }
}
