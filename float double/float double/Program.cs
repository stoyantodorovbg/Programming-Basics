using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_double
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatPi = 3.14f;
            Console.WriteLine(floatPi);
            double doublePi = 3.14;
            Console.WriteLine(doublePi);
            double nan = double.NaN;
            Console.WriteLine(nan);
            double infinity = double.PositiveInfinity;
            Console.WriteLine(infinity);
        }
    }
}
