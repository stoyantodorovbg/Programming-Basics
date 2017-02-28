using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chislo_na_stepen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number!");
                int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number!");
                int b = int.Parse(Console.ReadLine());
            decimal result = 1;
            for(int i=0; i<b; i++)
            {
                result *= a;
            }
            Console.WriteLine("a^b = " + result);

        }
    }
}
