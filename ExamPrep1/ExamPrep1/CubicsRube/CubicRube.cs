using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CubicsRube
{
    public class CubicRube
    {
        public static void Main()
        {
            var dimensionSize = int.Parse(Console.ReadLine());
            var sumParticles = 0L;
            var changedCells = 0;

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "Analyze")
            {
                var inputParams = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (inputParams.Take(3).Any(x => x < 0 || x >= dimensionSize))
                {
                    continue;
                }

                if (inputParams[3] != 0)
                {
                    sumParticles += inputParams[3];
                    changedCells++;
                }
            }

            Console.WriteLine(sumParticles);
            Console.WriteLine(Math.Pow(dimensionSize,3) - changedCells);
        }
    }
}
