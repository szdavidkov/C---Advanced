using System;
using System.Collections.Generic;
using System.Linq;


namespace ActionPrint
{
    public class ActionPoint
    {
       public static void Main()
       {
           var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

           for (int i = 0; i < inputLine.Length; i++)
           {
               Console.WriteLine(inputLine[i]);
           }
       }
    }
}
