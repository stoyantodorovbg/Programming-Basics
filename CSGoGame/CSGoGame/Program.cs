using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var rubles = decimal.Parse(Console.ReadLine());
            var dollars = decimal.Parse(Console.ReadLine());
            var euro = decimal.Parse(Console.ReadLine());
            var twoGamesLeva = decimal.Parse(Console.ReadLine());
            var leva = decimal.Parse(Console.ReadLine());
            rubles *= 0.035m;
            dollars *= 1.5m;
            euro *= 1.95m;
            twoGamesLeva /= 2m;
            var a = Math.Max(rubles, dollars);
            var b = Math.Max(euro, twoGamesLeva);
            var c = Math.Max(b, leva);
            var d = Math.Max(c, a);
            var f = Math.Round(d);
            var l = f;
            if (f < d)
            {
                f++;
                Console.WriteLine("{0}.00", f);
            }
            else
            {
                Console.WriteLine("{0}.00", l);
            }
        }
    }
}
