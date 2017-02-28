using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var a = Math.Max(x1, x2) - Math.Min(x1, x2);
            var b = Math.Max(y1, y2) - Math.Min(y1, y2);
            var area = a * b;
            var perimeter = (a + b) * 2;
            Console.WriteLine("The area of the rectangle is {0}, the perimeter is {1}.", area, perimeter);
        }
    }
}
