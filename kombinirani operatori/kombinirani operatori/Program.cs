using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kombinirani_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 4;
            Console.WriteLine(y *= 2);
            int z = y = 3;
            Console.WriteLine(z);
            Console.WriteLine(x |= 1);
            Console.WriteLine(x += 3);
            Console.WriteLine(x /= 2);
          
        }
    }
}
