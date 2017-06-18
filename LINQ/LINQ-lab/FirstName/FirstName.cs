using System;
using System.Collections.Generic;
using System.Linq;


namespace FirstName
{
    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var letters = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var name = string.Empty;

            foreach (var letter in letters)
            {
                name = names.Where(w => w.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();

                if (name != null)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
            if (name == null)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
