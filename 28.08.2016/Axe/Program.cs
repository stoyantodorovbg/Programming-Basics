using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;

            for (int i = 0; i < n; i ++)
            {
                Console.Write(new string('-', 3 * n));
                Console.Write($"*{new string('-', i)}*");
                Console.Write(new string('-', ((2 * n) - 2) - i));
                Console.WriteLine();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', (3 * n) + 1));
                Console.Write(new string('-', n - 1));
                Console.Write($"*{new string('-', n -1)}");
                Console.WriteLine();
            }

            for (a = 0;  a < n / 2 - 1; a++)
            {
                Console.Write(new string('-', 3 * n - a));
                Console.Write($"*{new string ('-', (n - 1) + 2 * a)}*");
                Console.Write(new string('-', n - 1 - a));
                Console.WriteLine();
            }

            Console.Write(new string('-', 3 * n - a));
            Console.Write(new string('*', (5 * n) - ((3 * n - a) + (n - 1 - a))));
            Console.Write(new string('-', n - 1 - a));
            Console.WriteLine();

        }
    }
}
