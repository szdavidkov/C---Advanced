using System;
using System.Collections.Generic;
using System.Linq;

    
public class TruckTour
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var pumps = new Queue<GasPump>();

        for (int i = 0; i < n; i++)
        {
            var pumpInfo = Console.ReadLine().Split();
            var distanceToNext = int.Parse(pumpInfo[1]);
            var amounthOfGas = int.Parse(pumpInfo[0]);

            GasPump pump = new GasPump(distanceToNext,amounthOfGas,i);
            pumps.Enqueue(pump);
        }

        GasPump starterPump = null;
        bool completeJorney = false;
        while (true)
        {
            
            var currentPump = pumps.Dequeue();
            pumps.Enqueue(currentPump);
            starterPump = currentPump;
            var gasInTank = currentPump.AmounthOfGas;

            while (gasInTank >= currentPump.DistanceToNext)
            {
                gasInTank -= currentPump.DistanceToNext;

                currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);

                if (currentPump == starterPump)
                {
                    completeJorney = true;
                    break;
                }
                gasInTank += currentPump.AmounthOfGas;
            }
            if (completeJorney)
            {
                Console.WriteLine(starterPump.IndexOfPump);
                break;
            }
        }
    }
}

public class GasPump
{
    public int DistanceToNext;
    public int AmounthOfGas;
    public int IndexOfPump;
    public GasPump(int distanceToNext, int amounthOfGas,int indexOfPump)
    {
        this.DistanceToNext = distanceToNext;
        this.AmounthOfGas = amounthOfGas;
        this.IndexOfPump = indexOfPump;
    }
}

