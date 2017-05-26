using System;
using System.Collections.Generic;
using System.Linq;


namespace AcademyGraduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string,List<double>>();
            for (int i = 0; i < number; i++)
            {
                var student = Console.ReadLine();
                var results = Console.ReadLine()
                    .Split(new [] { ' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();

                students.Add(student, results);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
