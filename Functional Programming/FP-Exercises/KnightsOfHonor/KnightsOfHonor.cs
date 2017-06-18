using System;
using System.Collections.Generic;
using System.Linq;


namespace KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < inputLine.Length; i++)
            {
                Console.WriteLine($"Sir {inputLine[i]}");
            }
        }
    }
}
