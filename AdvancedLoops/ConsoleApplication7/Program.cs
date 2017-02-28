using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (var i = 1; i <= 999999; i++)
            {
                var a1 = i % 10;
                i /= 10;
                var a2 = i % 10;
                i /= 10;
                var a3 = i % 10;
                i /= 10;
                var a4 = i % 10;
                i /= 10;
                var a5 = i % 10;
                i /= 10;
                var a6 = i % 10;
                i /= 10;

                if (a1 * a2 * a3 * a3 * a4 * a5 * a6 == n)
                {
                    Console.Write("{0}{1}{2}{3}{4}{5} ", a1, a2, a3, a4, a5, a6);

                }
            }
        }
    }
}


