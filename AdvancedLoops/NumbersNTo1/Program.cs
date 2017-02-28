using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var a = n; a >= 1; a --)
            {
                Console.WriteLine(a);
            }
        }
    }
}
