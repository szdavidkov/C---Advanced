﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupNUmbers
{
    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var zero = numbers.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            var one = numbers.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            var two = numbers.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            Console.WriteLine(String.Join(" ",zero));
            Console.WriteLine(String.Join(" ", one));
            Console.WriteLine(String.Join(" ", two));
        }
    }
}
