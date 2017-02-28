using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            bool greaterAB = (a > b);
            bool equalA1 = (a == 1);
            if (greaterAB)
                {
                Console.WriteLine("A>B");

            }
            else
            {
                Console.WriteLine("a<=B");
            }
            Console.WriteLine("greaterAB =" + greaterAB);
            Console.WriteLine("equalAB =" + equalA1);
        }
    }
}
