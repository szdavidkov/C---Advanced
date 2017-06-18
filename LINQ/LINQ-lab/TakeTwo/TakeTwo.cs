using System;
using System.Collections.Generic;
using System.Linq;


namespace TakeTwo
{
    public class TakeTwo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = numbers.Where(n => 10 <= n && n <= 20).Distinct().Take(2).ToList();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
