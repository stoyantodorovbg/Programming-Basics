using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumePool = double.Parse(Console.ReadLine());
            var capacityFirstTube = double.Parse(Console.ReadLine());
            var capacitySecondTube = double.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            if ( volumePool >= 1 && volumePool <= 10000
               && capacityFirstTube >= 1 && capacityFirstTube >= 1 
               && capacitySecondTube <= 5000 && capacitySecondTube >= 1 
               && hours >= 1.0 && hours <= 24.00)
            {
                var workOfTheFirstTube = capacityFirstTube * hours;
                var workOfTheSecondTube = capacitySecondTube * hours;
                var allWorkOfTheTubes = workOfTheFirstTube + workOfTheSecondTube;
                var percentFirstTube = 0d;
                var percentSecondTube = 0d;
                var percentAllWorksOfTheTibes = 0d;
                var overFlow = 0d;
                if (allWorkOfTheTubes < volumePool)
                {
                    percentFirstTube = (workOfTheFirstTube * 100) / allWorkOfTheTubes;
                    percentSecondTube = (workOfTheSecondTube * 100) / allWorkOfTheTubes;
                    percentAllWorksOfTheTibes = (allWorkOfTheTubes * 100) / volumePool;
                    Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%."
                        , Math.Round(percentAllWorksOfTheTibes), Math.Round(percentFirstTube)
                        , Math.Round(percentSecondTube));
                }
                else if (allWorkOfTheTubes >= volumePool)
                    overFlow = allWorkOfTheTubes - volumePool;
                Console.WriteLine("For {0} hours the pool overflows with {1} litres."
                    ,hours , Math.Round(overFlow));
            }
        }
    }
}
