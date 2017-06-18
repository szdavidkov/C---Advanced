using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseExclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var divisor = int.Parse(Console.ReadLine());

            var result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % divisor != 0)
                {
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
