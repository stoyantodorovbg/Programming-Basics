using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeThePlaneDown
{
    class Program
    {
        static void Main(string[] args)
        {
            var xHeadquarter = double.Parse(Console.ReadLine());
            var yHeadquarter = double.Parse(Console.ReadLine());
            var distanceToTheBorders = double.Parse(Console.ReadLine());
            var planes = double.Parse(Console.ReadLine());
            var xPlane = 0d;
            var yPlane = 0d;
            for (var a = 1; a <= planes; a++)
            {
                xPlane = double.Parse(Console.ReadLine());
                yPlane = double.Parse(Console.ReadLine());
                var c = Math.Max(xHeadquarter, xPlane) - Math.Min(xHeadquarter, xPlane);
                var b = Math.Max(yHeadquarter, yPlane) - Math.Min(yHeadquarter, yPlane);
                var distanceToThePlane = Math.Sqrt(c) + Math.Sqrt(b);
                if (distanceToTheBorders >= distanceToThePlane)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", xPlane, yPlane); 
                }
            }
        }
    }
}
