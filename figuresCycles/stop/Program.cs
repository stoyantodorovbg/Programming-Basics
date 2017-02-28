using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', ((((n * 2) + 2) * 2) - (n + 1) * 2) - 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();

            for (var row = 0; row < n; row ++)
            {
                Console.Write(new string('.', n - row));
                Console.Write("//");
                Console.Write(new string
                    ('_', ((((((n * 2) + 2) * 2) - (n + 1) * 2) - 2) - 1) + (2 * row)));
                Console.Write("\\");
                Console.Write("\\");
                Console.Write(new string('.', n - row));
                Console.WriteLine();
            }

            Console.Write("//");
            Console.Write(new string('_', (2 * n) - 3));
            Console.Write("STOP!");
            Console.Write(new string('_', (2 * n) - 3));
            Console.Write('\\');
            Console.Write('\\');
            Console.WriteLine();

            for (var row = 0; row < n; row ++)
            {
                Console.Write(new string('.', row));
                Console.Write("\\");
                Console.Write("\\");
                Console.Write(new string
                    ('_', (4 * n) - (1 + 2 * row)));
                Console.Write("//");
                Console.Write(new string('.', row));
                Console.WriteLine();
            }
        }
    }
}
