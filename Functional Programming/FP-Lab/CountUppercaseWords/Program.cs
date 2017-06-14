using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace CountUppercaseWords
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            var result = new List<string>();

            for (int index = 0; index < inputLine.Count; index++)
            {
                if (char.IsUpper(inputLine[index]))
                {
                    result.Add(inputLine[index]);
                }
            }


        }
    }
}
