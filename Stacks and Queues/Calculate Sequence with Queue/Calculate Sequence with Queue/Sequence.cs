using System;
using System.Collections.Generic;
using System.Linq;


public class Sequence
{
    public static void Main()
    {
        var n = long.Parse(Console.ReadLine());
        var elementsInSequence = new Queue<long>();
        var result = new List<long>();
        elementsInSequence.Enqueue(n);
        result.Add(n);

        while (result.Count < 50)
        {
            var currentElement = elementsInSequence.Dequeue();
            var firstNumber = currentElement + 1;
            var secondNumber = (currentElement * 2) + 1;
            var thirdNumber = currentElement + 2;
            elementsInSequence.Enqueue(firstNumber);
            elementsInSequence.Enqueue(secondNumber);
            elementsInSequence.Enqueue(thirdNumber);

            result.Add(firstNumber);
            result.Add(secondNumber);
            result.Add(thirdNumber);
        }
        for (int i = 0; i < 50; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}

