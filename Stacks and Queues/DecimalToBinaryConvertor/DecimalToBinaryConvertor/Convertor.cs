﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace DecimalToBinaryConvertor
{
    public class Convertor
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (number!= 0)
                {
                    stack.Push(number % 2);
                    number /= 2;
                }
                while (stack.Count != 0)
                {
                    Console.Write(stack.Pop());
                }
                Console.WriteLine();
            }

        }
    }
}
