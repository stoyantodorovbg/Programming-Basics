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
            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char downDash = '_';

            Console.Write($"{new string(dot, n + 1)}{new string(downDash, (2 * n) + 1)}{new string(dot, n + 1)}");
            Console.WriteLine();

            for (int row = 0; row < n; row++)
            {
                Console.Write($"{new string(dot, n - row)}//{new string(downDash, ((2 * n) - 1) + 2 * row)}\\\\{new string(dot, n - row)}");
                Console.WriteLine();
            }

            Console.Write($"//{new string (downDash, n + (n - 3))}STOP!{new string(downDash, n + (n - 3))}\\\\");
            Console.WriteLine();

            for (int row = 0; row < n; row++)
            {
                Console.Write($"{new string(dot, row)}\\\\{new string(downDash, ((4 * n) - 1) - 2 * row)}//{new string(dot, row)}");
                Console.WriteLine();
            }

        }
    }
}
