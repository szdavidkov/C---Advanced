using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace CubicAssaut
{
    public class CubicAssaut
    {
        public static int ConvertThresHold = 1_000_000;
        public static void Main()
        {
            var meteorNames =  new List<string>() {"Green", "Red", "Black"};

            var regions = new Dictionary<string, Dictionary<string,long>>();

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "Count em all")
            {
                var regionParams = inputLine.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var regionName = regionParams[0];
                var meteorType = regionParams[1];
                var meteorCount = int.Parse(regionParams[2]);

                if (!regions.ContainsKey(regionName))
                {
                    regions[regionName] = new Dictionary<string, long>() {{"Green",0} , {"Red",0} , {"Black",0}};
                }
                regions[regionName][meteorType] += meteorCount;

                for (int i = 0; i < meteorCount - 1; i++)
                {
                    var nextTypeCount = regions[regionName][meteorNames[i]] / ConvertThresHold;
                    if (nextTypeCount > 0)
                    {
                        regions[regionName][meteorNames[i + 1]] += nextTypeCount;
                        regions[regionName][meteorNames[i]] %= ConvertThresHold;
                    }
                }
            }

            var orderedRegions = regions
                .OrderByDescending(x => x.Value["Black"])
                .ThenBy(x => x.Key.Length)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var region in orderedRegions)
            {
                Console.WriteLine(region.Key);
                foreach (var meteorType in region.Value.OrderByDescending(m => m.Value).ThenBy(
                    m => m.Key))
                {
                    Console.WriteLine($"-> {meteorType.Key} : {meteorType.Value}");
                }
            }
        }
    }
}
