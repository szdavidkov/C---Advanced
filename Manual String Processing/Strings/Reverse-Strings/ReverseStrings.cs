using System;
using System.Collections.Generic;
using System.Linq;


namespace Reverse_Strings
{
    public class ReverseStrings
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var result = new string(inputLine.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
