using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace TestVehicle.Services.VehicleServices
{
    public class InstanceService<T>
    {
        public IEnumerable<T> GetInstances()
        {
            IEnumerable<Type> types = typeof(T).Assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(T)));
            IEnumerable<T> instances = types.Select(x =>
            {
                return (T)Activator.CreateInstance(x);
            });

            return instances;
        }
    }
}
