using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorForStupidPassport
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            var differ = Math.Abs(l - n); 

            var one = 0;
            var two = 0;
            var three = ' ';
            var four = ' ';
            var five = 0;
            
            for (var a = 1; a < n; a ++)
            {
                for (var b = 1; b <= a; b ++)
                {
                    for (var c = 0; c < differ; c++)
                    {
                        Console.Write("{0}{1} ", a, b);
                    }
                }
            }



        }
    }
}
