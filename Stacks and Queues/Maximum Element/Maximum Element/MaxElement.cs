using System;
using System.Collections.Generic;
using System.Linq;

public class MaxElement
{
    public static void Main()
    {
        var myStack = new Stack<int>();
        var maxNumbers = new Stack<int>();
        var maxNumber = int.MinValue;
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var commands = Console.ReadLine().Split();
            var command = commands[0];
            if (command == "1")
            {
                var numberToPush = int.Parse(commands[1]);
                myStack.Push(numberToPush);
                if (maxNumber <= numberToPush)
                {
                    maxNumber = numberToPush;
                    maxNumbers.Push(maxNumber);
                }
            }
            else if (command == "2")
            {
                int elementAtTop = myStack.Pop();
                var currentMaxNumber = maxNumbers.Peek();
                if (elementAtTop == currentMaxNumber)
                {
                    maxNumbers.Pop();
                    if (maxNumbers.Count > 0)
                    {
                        maxNumber = maxNumbers.Peek();
                    }
                    else
                    {
                        maxNumber = int.MinValue;
                    }
                }
            }
            else
            {
                Console.WriteLine(maxNumbers.Peek());
            }
        }
    }
}

