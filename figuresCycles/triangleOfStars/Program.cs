using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var a = 1; a <= n; a ++)
            {
                for (var b = 1; b <= a; b ++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
