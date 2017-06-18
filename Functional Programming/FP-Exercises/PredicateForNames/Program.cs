using System;
using System.Collections.Generic;
using System.Linq;


namespace PredicateForNames
{
    public class Program
    {
        public static void Main()
        {
            var nameLenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var result = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length <= nameLenght)
                {
                    result.Add(names[i]);
                }
            }

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
