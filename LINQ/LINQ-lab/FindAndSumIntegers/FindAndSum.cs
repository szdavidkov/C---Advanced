using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSumIntegers
{
    public class FindAndSum
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ')
                .Select(n => {
                    long value;
                    bool success = long.TryParse(n, out value);
                    return new { value, success };
                })
                .Where(b => b.success)
                .Select(x => x.value)
                .ToList();
            long sum = 0;
            if (numbers.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No match");
            }
            

        }
    }
}
