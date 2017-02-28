using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectInHospitality
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = decimal.Parse(Console.ReadLine());
            var r = decimal.Parse(Console.ReadLine());
            var c = decimal.Parse(Console.ReadLine());
            var t = decimal.Parse(Console.ReadLine());
            var o = decimal.Parse(Console.ReadLine());
            var n = decimal.Parse(Console.ReadLine());
            var u = decimal.Parse(Console.ReadLine());
            var s = decimal.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());

            b *= 1500.04m;
            r *= 2102.10m;
            c *= 1465.46m;
            t *= 2053.33m;
            o *= 3010.98m;
            n *= u;

            var amount = b + r + c + t + o + n + s;
            var left = m - amount;
            var needSum = Math.Abs(m - amount);

            Console.WriteLine("The amount is: {0} lv.", Math.Round(amount, 2));
            
            if (b + r + c + t + o + n + s <= m)
            {
                Console.WriteLine("YES \\ Left: {0} lv.", Math.Round(left, 2));
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0} lv.", Math.Round(needSum, 2));
            }

        }
    }
}
