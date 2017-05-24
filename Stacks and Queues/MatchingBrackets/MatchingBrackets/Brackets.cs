using System;
using System.Collections.Generic;
using System.Linq;


namespace MatchingBrackets
{
    public class Brackets
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var ch = inputLine[i];
                if (ch == '(')
                {
                    stack.Push(i);
                    
                }
                else if (ch == ')')
                {
                    var startIndex = stack.Pop();
                    var contents = inputLine.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(contents);
                }
            }
        }
    }
}
