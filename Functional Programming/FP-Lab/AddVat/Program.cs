using System;
using System.Collections.Generic;
using System.Linq;


namespace AddVat
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n *= 1.2)
                .ToList();
            
            foreach (var number in inputLine)
            {
                Console.WriteLine($"{number:f2}");
            }

        }
    }
}
