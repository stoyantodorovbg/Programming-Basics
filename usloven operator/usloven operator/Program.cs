using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usloven_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            Console.WriteLine(a > b ? "a>b" : "a<=b");
            int num = a == b ? 1 : -1;
            Console.WriteLine(num);
        }
    }
}
