using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.Write('\\');
            if (n % 2 != 0)
            {
                Console.Write(new string('_', (n - 3)));
            }
            else if (n % 2 == 0)
            {
                Console.Write(new string('_', (n - 4)));
            }
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.Write('\\');
            Console.WriteLine();

                for (var row = 0; row < n - 3; row++)
                {
                    Console.Write('|');
                    Console.Write(new string(' ', (2 * n) - 2));
                    Console.Write('|');
                    Console.WriteLine();
                }

            Console.Write('|');
            Console.Write(new string(' ', ((2 * n) / 4) + 1));
            if (n % 2 != 0)
            {
                Console.Write(new string('_', (n - 3)));
            }
            else if (n % 2 == 0)
            {
                Console.Write(new string('_', (n - 4)));
            }

            Console.Write(new string(' ', ((2 * n) / 4) + 1));
            Console.Write('|');
            Console.WriteLine();

            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.Write('/');

            if (n % 2 != 0)
            {
                Console.Write(new string(' ', (n - 3)));
            }
            else if (n % 2 == 0)
            {
                Console.Write(new string(' ', (n - 4)));
            }
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.Write('/');

        }
    }
}
