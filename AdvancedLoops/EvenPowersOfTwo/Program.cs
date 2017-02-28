using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (var a = 0; a <= n; a += 2)
            {
                Console.WriteLine(num);
                num = num * 4;
            }
        }
    }
}
