using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            do
            {
                factoriel *= n;
                n--;
            } while (n > 1);
            Console.WriteLine("Factoriel is: " + factoriel);
        }
    }
}
