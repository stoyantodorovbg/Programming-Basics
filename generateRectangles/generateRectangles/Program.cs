using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var x1 = 0;
            var y1 = 0;
            var x2 = 0;
            var y2 = 0;

            for (var a = -n; a <= ; a ++)
            {
                x1 = a;
                y1 = a;
                x2 = x1 + Math.Sqrt(m);
                y2 = y1 + Math.Sqrt(m);
            }
        }
    }
}
