using System;
using System.Collections.Generic;
using System.Linq;


namespace Formattin_Numbers
{
    public class FomattingNumbers
    {
        public static void Main()
        {
            
            var intA = int.Parse(Console.ReadLine());
            while (intA < 0 || intA > 2222)
            {
                Console.WriteLine("Invalid input! Try again!");
                intA = int.Parse(Console.ReadLine());
            }
            var decimalB = decimal.Parse(Console.ReadLine());
            var decimalC = decimal.Parse(Console.ReadLine());
            Console.Write("{0,-10:x}", intA);
            Console.Write(Convert.ToString(intA, 2).PadLeft(10, '0'));
            Console.Write("{0,10:F3}", decimalB);
            Console.Write("{0,-10:F3}", decimalC);
        }
    }
}
