using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using TestVehicle.Entities;

namespace TestVehicle.Services.VehicleServices
{
    public class VehicleService
    {
        public void WriteTypesAlphabeticaly()
        {
            IEnumerable<Type> types = typeof(Vehicle).Assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(Vehicle)));
            types.OrderBy(x => x.Name).ToList().ForEach(x =>
            {
                Console.WriteLine(x.Name);
            });
        }

        public IEnumerable<Type> SearchByName(string name)
        {
            if (String.IsNullOrEmpty(name))
                return Enumerable.Empty<Type>();
            var types = typeof(Vehicle).Assembly.GetTypes().
                Where(type => type.IsSubclassOf(typeof(Vehicle)) && type.Name.ToLower().Contains(name.ToLower()));
            
            return types;
        }

        public void WriteInstancesToFile(IEnumerable<Vehicle> instances)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            FileStream fs = new FileStream("vehicles.json", FileMode.OpenOrCreate);
            JsonSerializer.SerializeAsync(fs, instances, options);
        }
    }
}
