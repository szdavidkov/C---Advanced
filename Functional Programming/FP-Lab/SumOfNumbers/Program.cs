using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();

            var countOfInputLine = inputLIne
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Count();
            var sumOfInputLine = inputLIne
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Sum();

            Console.WriteLine(countOfInputLine);
            Console.WriteLine(sumOfInputLine);


        }
    }
}
