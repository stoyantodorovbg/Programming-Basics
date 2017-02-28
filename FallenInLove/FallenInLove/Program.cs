using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= 18)
            {
                var dot = ".";
                var ds = "#";
                var tire = "~";
                for (var b = 1; b <= 2; b++)
                {
                    Console.Write(ds + ds);
                    for (var a = 1; a <= n; a++)
                    {
                        Console.Write(dot + dot);
                    }
                    
                }
                Console.WriteLine(ds + ds);
                for (var c = 1; c < n; c ++)
                {
                    
                }
            }
        }
    }
}
