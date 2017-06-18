using System;
using System.Collections.Generic;
using System.Linq;


namespace CustomComparator
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var result = numbers.OrderBy(n => n % 2 == 1).ThenBy(n => n);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
