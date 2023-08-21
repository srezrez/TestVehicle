using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestVehicle.Const;

namespace TestVehicle.Entities
{
    public class Bicycle : Vehicle
    {
        public int SpeedsAmount { get; }

        public Bicycle() : base(BicycleBrand, BicycleModel)
        {
            SpeedsAmount = BicycleSpeedsAmount;
        }
    }
}
