using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            n -= 2;
            {
                Console.Write("+ ");
            }
            for (var b = 0; b < n; b ++)
            {
                Console.Write("- ");
            }
            Console.Write("+ ");
            Console.WriteLine();

            for (var a = 0; a < n; a++)
            {
                Console.Write("| ");
                for ( var c = 0; c < n; c ++)
                {
                    Console.Write("- ");
                }
                Console.Write("| ");
                Console.WriteLine();
            }

            {
                Console.Write("+ ");
            }
            for (var b = 0; b < n; b++)
            {
                Console.Write("- ");
            }
            Console.Write("+ ");
            Console.WriteLine();
        }
    }
}
