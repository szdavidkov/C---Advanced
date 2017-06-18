using System;
using System.Collections.Generic;
using System.Linq;


namespace FindEvenOrOdds
{
    public class FindEvenOdd
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();
            var lowerBound = input[0];
            var higherBound = input[1];
            

            if (command == "odd")
            {
                var oddResult = new List<int>();
                for (int i = lowerBound; i <= higherBound; i++)
                {
                    if (lowerBound % 2 == 1)
                    {
                        oddResult.Add(lowerBound);
                    }
                    lowerBound++;
                }

                Console.WriteLine(string.Join(" ",oddResult));
            }

            if (command == "even")
            {
                var evenResult = new List<int>();
                for (int i = lowerBound; i <= higherBound; i++)
                {
                    if (lowerBound % 2 == 0)
                    {
                        evenResult.Add(lowerBound);
                    }
                    lowerBound++;
                }

                Console.WriteLine(string.Join(" ", evenResult));
            }
        }
    }
}
