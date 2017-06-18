using System;
using System.Collections.Generic;
using System.Linq;


namespace AppliedArithmetics
{
    public class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine();
            var result = new List<int>();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            result.Add(numbers[i]++);
                        }
                        return;
                    case "print":
                        Console.WriteLine(string.Join(" ",result));
                        return;
                    case "multiply":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            result.Add(numbers[i] *= 2);
                        }
                        return;
                    case "subtract":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            result.Add(numbers[i]--);
                        }
                        return;
                        
                }

                command = Console.ReadLine();
            }

        }
    }
}
