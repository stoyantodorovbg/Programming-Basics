using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var h = Math.Min(firstNumber, secondNumber);
            var w = Math.Max(firstNumber, secondNumber);
            if (3 <= h && h <= w && w <= 100)
                {
                double placeArea = 1.20 * 0.70;
                double usefullnessWidth = ((double) w % 1.20);
                double usefullnessHeight = ((double) (h - 1.00) % 0.70);
                double realWidth = w - usefullnessWidth;
                double realHeight = (h - 1.00) - usefullnessHeight;
                double places = ((Double)(realWidth * realHeight) / placeArea) - 3;

                Console.WriteLine(places);
                
                }
            



        }
    }
}
