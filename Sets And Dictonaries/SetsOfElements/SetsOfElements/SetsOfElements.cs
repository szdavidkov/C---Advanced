using System;
using System.Collections.Generic;
using System.Linq;


namespace SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var result = new HashSet<int>();
            var n = input[0];
            var m = input[1];

            var listOfN = new List<int>();
            var listOfM = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                listOfN.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                var number = int.Parse(Console.ReadLine());
                listOfM.Add(number);
            }

            
        }
    }
}
