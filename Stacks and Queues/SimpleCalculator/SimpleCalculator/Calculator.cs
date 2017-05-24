using System;
using System.Collections.Generic;
using System.Linq;


namespace SimpleCalculator
{
    public class Calculator
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var values = inputLine.Split(' ');
            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                var firstElement = int.Parse(stack.Pop());
                var operation = stack.Pop();
                var secondElement = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    stack.Push((firstElement + secondElement).ToString());
                }
                else
                {
                    stack.Push((firstElement - secondElement).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
