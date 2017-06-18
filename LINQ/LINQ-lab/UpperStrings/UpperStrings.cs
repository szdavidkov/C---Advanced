using System;
using System.Collections.Generic;
using System.Linq;


namespace UpperStrings
{
    public class UpperStrings
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = words.Select(w => w.ToUpper()).ToList();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
