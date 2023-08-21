using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestVehicle.Entities
{
    [JsonPolymorphic]
    public abstract class Vehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public Vehicle() {}
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
