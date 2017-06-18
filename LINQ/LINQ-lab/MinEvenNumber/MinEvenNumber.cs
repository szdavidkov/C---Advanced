using System;
using System.Collections.Generic;
using System.Linq;


namespace MinEvenNumber
{
    public class MinEvenNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var result = numbers.Where(n => n % 2 == 0).Min();
            Console.WriteLine($"{result:f2}");
        }
    }
}
