using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var pointX = double.Parse(Console.ReadLine());
            var pointY = double.Parse(Console.ReadLine());
            if ((pointX > 0 && pointX < h * 3 && pointY > 0 && pointY < h) ||
                (pointX > h && pointX < 2 * h && pointY > h && pointY < 4 * h))
            {
                Console.WriteLine("inside");
            }
            else if (pointX < 0 || pointX > h * 3 || pointY < 0 || 
                (pointY > h && (pointX < h && pointX > 2 * h)) ||
            (pointX > h * 2 && pointY > h) || 
            (pointX < h && pointY > h) || pointY > 4 * h)
            {
                Console.WriteLine("outside");
            }
            else if (pointX > h && pointX < 2 * h && pointY == h)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
