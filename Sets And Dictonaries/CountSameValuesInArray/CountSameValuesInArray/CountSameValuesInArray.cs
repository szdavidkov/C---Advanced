using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var numbersLikeString = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var dict = new SortedDictionary<double,int>();
            var nums = new double[numbersLikeString.Length];

            foreach (var number in numbersLikeString)
            {
                double num;  
                if (number.Contains(","))
                {
                    num = double.Parse(number.Replace(",", "."), CultureInfo.InvariantCulture);
                }
                else
                {
                    num = double.Parse(number, CultureInfo.InvariantCulture);
                }

                if (!dict.ContainsKey(num))
                {
                    dict.Add(num,1);
                }
                else
                {
                    dict[num]++;
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times ");
            }
        }
    }
}
