using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    public class AMinerTaask
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, int>();

            while (true)
            {
                if (result.ContainsKey(input))
                {
                    result[input] += number;
                }
                else
                {
                    result.Add(input, number);
                }
                input = Console.ReadLine();
                if (input.Equals("stop"))
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
