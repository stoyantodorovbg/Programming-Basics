using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsdToBgN
{
    class Program
    {
        static void Main(string[] args)
        {
            var dolars = decimal.Parse(Console.ReadLine());
            var leva = dolars * 1.79549m;
            Console.WriteLine(Math.Round(leva, 2));

        }
    }
}
