using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal skumriaPrice = decimal.Parse(Console.ReadLine());
            decimal cacaPrice = decimal.Parse(Console.ReadLine());
            decimal palamudQuentity = decimal.Parse(Console.ReadLine());
            decimal safridQuentity = decimal.Parse(Console.ReadLine());
            decimal midiQuentity = decimal.Parse(Console.ReadLine());

            decimal palamudPrice = skumriaPrice + (skumriaPrice * 0.6m);
            decimal safridPrice = cacaPrice + (cacaPrice * 0.8m);
            decimal midiPrice = 7.50m;

            decimal sum = (palamudPrice * palamudQuentity) + (safridPrice * safridQuentity) + (midiPrice * midiQuentity);

            Console.WriteLine(Math.Round(sum, 2));
        }
    }
}
