using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleOfStrars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;

            for (var a = 0; a < n; a ++)
            {
                for (var b = 0; b < 10; b ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
