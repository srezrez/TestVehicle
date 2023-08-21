using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVehicle.Services.ProblemService
{
    public class ProblemService
    {
        public string ReverseString(string str)
        {
            var chars = str.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public string ReverseStringSecond(string str)
        {
            var result = new StringBuilder(str.Length);
            for(int i = str.Length - 1; i > -1; i--)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public bool IsPalindrome(string str)
        {
            return str == ReverseString(str);
        }

        public bool IsPalindromeSecond(string str)
        {
            var length = str.Length;
            for(int i = 0; i < length/2; i++) {
                if (str[i] != str[length - i - 1])
                    return false;
            }

            return true;
        }

        public IEnumerable<int> IsMissingElements(int[] arr)
        {
            var length = arr.Length == 0 ? 0 : arr.Last() - arr.First() - arr.Length + 1;
            List<int> result = new List<int>(length);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var start = arr[i] + 1;
                var count = arr[i + 1] - start;
                if(count != 0)
                {
                    var range = Enumerable.Range(start, count);
                    result.AddRange(range);
                }               
            }
            return result.ToArray();
        }
    }
}
