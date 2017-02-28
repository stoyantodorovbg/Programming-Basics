using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal factoriel = 1;
            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factoriel *= n;
                n--;
            }
            Console.WriteLine("Factoriel of this number is " + factoriel);
        }
    }
}
