using System;
using System.Collections.Generic;
using System.Linq;


namespace HotPotato
{
    public class Potato
    {
        public static void Main()
        {
            var children = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 0; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}