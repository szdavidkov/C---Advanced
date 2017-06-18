using System;
using System.Collections.Generic;
using System.Linq;


namespace AverageOfDoubles
{
    public class AverageOfDoubles
    {
        public static void Main()
        {
            var averageNumber = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Average();

            Console.WriteLine($"{averageNumber:f2}");
        }
    }
}
