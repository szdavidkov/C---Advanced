using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var stackOfReversedNumbers = new Stack<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            stackOfReversedNumbers.Push(numbers[i]);
        }

        Console.WriteLine(string.Join(" ",stackOfReversedNumbers));
    }
}

