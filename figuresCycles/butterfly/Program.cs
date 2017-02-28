using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butterfly
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            for (var row = 1; row <= n - 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.Write(new string('*', (((2 * n) - 4) / 2)));
                    Console.Write("\\ /");
                    Console.Write(new string('*', (((2 * n) - 4) / 2)));
                }
                else
                {
                    Console.Write(new string('-', (((2 * n) - 4) / 2)));
                    Console.Write("\\ /");
                    Console.Write(new string('-', (((2 * n) - 4) / 2)));
                }
                Console.WriteLine();
            }

            Console.Write("{0}@", new string(' ', (((2 * n) - 2) / 2)));
            Console.WriteLine();

            for (var row = 1; row <= n - 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.Write(new string('*', (((2 * n) - 4) / 2)));
                    Console.Write("/ \\");
                    Console.Write(new string('*', (((2 * n) - 4) / 2)));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('-', (((2 * n) - 4) / 2)));
                    Console.Write("/ \\");
                    Console.Write(new string('-', (((2 * n) - 4) / 2)));
                    Console.WriteLine();
                }
            }
        }
    }
}
