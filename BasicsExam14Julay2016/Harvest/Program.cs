using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double vineYardArea = double.Parse(Console.ReadLine());
            double grapesForMeter = double.Parse(Console.ReadLine());
            double needWine = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double wine = ((vineYardArea * 0.4d) * grapesForMeter) / 2.5;
            double difference = Math.Abs(wine - needWine);
            double litersPerPerson = difference / workers;

            if (wine < needWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(litersPerPerson)} liters per person.");
            }
        }
    }
}
