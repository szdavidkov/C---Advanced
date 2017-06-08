using System;
using System.Collections.Generic;
using System.Linq;


namespace Count_Substring_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            
            var subString = Console.ReadLine();

            int count = inputLine.Select((c, i) => inputLine.Substring(i)).Count(x => x.StartsWith(subString, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(count);
        }
    }
}
