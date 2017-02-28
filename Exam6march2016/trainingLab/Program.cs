using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double width = Math.Min(n, m);
            double hight = Math.Max(n, m);

            width --;

            double trainingHallArea = (width * hight);
            double tableOnRow = Math.Floor(width / 0.70);
            double rows = Math.Floor(hight / 1.20);
            double workPlaces = tableOnRow * rows - 3;

            Console.WriteLine(Math.Floor(workPlaces));
        }
    }
}
