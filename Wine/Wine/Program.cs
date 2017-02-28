using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var kgGrapeM = double.Parse(Console.ReadLine());
            var expectedL = double.Parse(Console.ReadLine());
            var lorkers = int.Parse(Console.ReadLine());
            if (area > 10 && area > 5000 && kgGrapeM > 0.00 && kgGrapeM < 10.00 && expectedL > 10 && expectedL < 600 && lorkers > 1 && lorkers < 10)
            {
                var usedHarvest = 
            }

        }
    }
}
