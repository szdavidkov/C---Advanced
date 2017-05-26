using System;
using System.Collections.Generic;
using System.Linq;


namespace SoftuniParty
{
    public class SoftuniParty
    {
        public static void Main()
        {
            var reservations = new SortedSet<string>();
            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                reservations.Add(input);
                input = Console.ReadLine();
            }
            while (input!= "END")
            {
                reservations.Remove(input); 
                input = Console.ReadLine();
            }

            Console.WriteLine(reservations.Count);
            foreach (var reservation in reservations)
            {
                Console.WriteLine(reservation);
            }

        }
    }
}
