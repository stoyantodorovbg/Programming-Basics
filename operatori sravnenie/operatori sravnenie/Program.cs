using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatori_sravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 5;
            Console.WriteLine("x>y: " + (x > y));
            Console.WriteLine("x<y: " + (x < y));
            Console.WriteLine("x>=y: " + (x >= y));
            Console.WriteLine("x<=y: " + (x <= y));
            Console.WriteLine("x==y: " + (x == y));
            Console.WriteLine("x!=y: " + (x != y));

        }
    }
}
