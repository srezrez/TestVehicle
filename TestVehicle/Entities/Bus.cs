using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestVehicle.Const;

namespace TestVehicle.Entities
{
    public class Bus : Vehicle
    {
        public int PassengersAmount { get; }

        public Bus() : base(BusBrand, BusModel)
        {
            PassengersAmount = BusPassengersAmount;
        }

    }
}
