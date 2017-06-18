using System;
using System.Collections.Generic;
using System.Linq;


namespace CustomMin
{
    public class CustomMinFunc
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(inputLine.Min());
        }
    }
}
