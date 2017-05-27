using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var result  = new SortedDictionary<char,int>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var symbol = inputLine[i];

                if (!result.ContainsKey(symbol))
                {
                    result.Add(symbol,1);
                }
                else
                {
                    result[symbol]++;
                }
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
