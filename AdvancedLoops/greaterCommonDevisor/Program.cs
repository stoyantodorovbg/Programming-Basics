using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterCommonDevisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var bigger = Math.Max(a, b);
            var lesser = Math.Min(a, b);
            var remainder = 1;
            var oldRemainder = 10;

            while(remainder != 0)
            {
                oldRemainder = lesser;
                remainder = bigger % lesser;
                bigger = lesser;
                lesser = remainder;
              
            }
            Console.WriteLine(oldRemainder);


        }
    }
}
