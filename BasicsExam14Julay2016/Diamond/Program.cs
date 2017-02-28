using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write($"{new string('.', n)}{new string('*', 3 * n)}{new string('.', n)}");
            Console.WriteLine();

            for(int i = 1; i <= n - 1; i++)
            {
                Console.Write($"{new string('.', n - i)}*{new string('.', ((3 * n) - 2) + 2 * i)}*{new string('.', n - i)}");
                Console.WriteLine();
            }

            Console.Write(new string('*', 5 * n));
            Console.WriteLine();

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write($"{new string('.', i + 1)}*{new string('.', ((4 * n) - 2 * i) + (n - 4))}*{new string('.', i + 1)}");
                Console.WriteLine();
            }

            Console.Write($"{new string('.',(2 * n) + 1)}{new string('*', n - 2)}{new string('.', (2 * n) + 1)}");
            Console.WriteLine();
        }
    }
}
