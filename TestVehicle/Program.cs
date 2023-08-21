using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVehicle.Entities;
using TestVehicle.Services.ProblemService;
using TestVehicle.Services.VehicleServices;

namespace TestVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instanceService = new InstanceService<Vehicle>();
            var vehicleService = new VehicleService();
            var problemService = new ProblemService();

            var instances = instanceService.GetInstances();
            Console.WriteLine("Instances:");
            foreach ( var instance in instances )
            {
                Console.WriteLine( instance );
            }

            Console.WriteLine("\nTypes sorted alphabeticaly:");
            vehicleService.WriteTypesAlphabeticaly();

            Console.WriteLine("\nInput value for search:");
            var search = Console.ReadLine();
            var types = vehicleService.SearchByName(search);
            Console.WriteLine("\nSearch results:");
            foreach (var type in types) { Console.WriteLine(type.Name); }

            vehicleService.WriteInstancesToFile(instances);

            Console.WriteLine("\nInput string for reverse:");
            var reverseStr = Console.ReadLine();
            Console.WriteLine("Reversed string is: " + problemService.ReverseString(reverseStr));
            Console.WriteLine("Reversed string from second method is: " + problemService.ReverseStringSecond(reverseStr));

            Console.WriteLine("\nInput string for palindrome:");
            var palindromeStr = Console.ReadLine();
            Console.WriteLine("IsPalindrome: " + problemService.IsPalindrome(palindromeStr));
            Console.WriteLine("IsPalindromeSecond: " + problemService.IsPalindromeSecond(palindromeStr));

            var arr = new int[] {3, 5, 9};
            Console.WriteLine("\nMissing elements: ");
            var result = problemService.IsMissingElements(arr);
            foreach(var item in result)
                Console.WriteLine(item);
        }
    }
}
