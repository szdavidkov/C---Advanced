using System;
using System.Collections.Generic;
using System.Linq;


namespace SortEvenNumbers
{
    public class Program
    {
        public static void Main()
        {

            var inputLIne = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = inputLIne
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
