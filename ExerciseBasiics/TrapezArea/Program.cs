using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = ((b1 + b2) / 2d) * h;
            Console.WriteLine(area);
        }
    }
}
