using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fact = 1;

            while(n < 1 || n > 12)
            {
                n = int.Parse(Console.ReadLine());
            }

            for (var i = 1; i <= n; i ++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
