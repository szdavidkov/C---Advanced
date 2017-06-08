using System;
using System.Collections.Generic;
using System.Linq;


namespace String_Lenght
{
    public class StringLength
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            string result = null;

            if (inputLine.Length == 20)
            {
                Console.WriteLine(inputLine);
            }
            else if (inputLine.Length < 20)
            {
                var tokens = new string('*',20 - inputLine.Length);
                result = string.Concat(inputLine, tokens);
                Console.WriteLine(result);
            }
            else
            {
                var result20 = inputLine.Take(20).ToArray();
                Console.WriteLine(result20);
            }
        }
    }
}
