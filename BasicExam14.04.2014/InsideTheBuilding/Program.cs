using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideTheBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());
            var x4 = int.Parse(Console.ReadLine());
            var y4 = int.Parse(Console.ReadLine());
            var x5 = int.Parse(Console.ReadLine());
            var y5 = int.Parse(Console.ReadLine());

            if (x1 >= 0 && x1 <= h * 3 && y1 >= 0 && y1 <= h ||
                x1 >= h && x1 <= h * 2 && y1 >= h && y1 <= h * 4)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

             if (x2 >= 0 && x2 <= h * 3 && y2 >= 0 && y2 <= h ||
                x2 >= h && x2 <= h * 2 && y2 >= h && y2 <= h * 4)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

             if (x3 >= 0 && x3 <= h * 3 && y3 >= 0 && y3 <= h ||
                x3 >= h && x3 <= h * 2 && y3 >= h && y3 <= h * 4)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

             if (x4 >= 0 && x4 <= h * 3 && y4 >= 0 && y4 <= h ||
                x4 >= h && x4 <= h * 2 && y4 >= h && y4 <= h * 4)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

             if (x5>= 0 && x5 <= h * 3 && y5 >= 0 && y5 <= h ||
                x5 >= h && x5 <= h * 2 && y5 >= h && y5 <= h * 4)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
