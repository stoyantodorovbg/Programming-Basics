using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readOfOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert a number! ");
            int n = int.Parse(Console.ReadLine());
            for (int a = 0; a < n; a ++)
            {
                Console.Write(" " + a);
            }
        }
    }
}
