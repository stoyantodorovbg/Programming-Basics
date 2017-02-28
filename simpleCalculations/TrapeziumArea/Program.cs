using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapeziumArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = ((a + b) * h) / 2;
            Console.WriteLine("The trapezoid area is {0}.", area);

        }
    }
}
