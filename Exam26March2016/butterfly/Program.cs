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
            int n = int.Parse(Console.ReadLine());

            char star = '*';
            char dash1 = '\\';
            char dash2 = '/';
            char dash3 = '-';
            char empty = ' ';

            for (int i = 1; i <= n -2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{new string(star, n - 2)}{dash1}{empty}{dash2}{new string(star, n - 2)}");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"{new string(dash3, n - 2)}{dash1}{empty}{dash2}{new string(dash3, n - 2)}");
                    Console.WriteLine();
                }
            }

            Console.Write($"{new string(empty, n - 1)}@{new string(empty, n - 1)}");
            Console.WriteLine();

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{new string(star, n - 2)}{dash2}{empty}{dash1}{new string(star, n - 2)}");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"{new string(dash3, n - 2)}{dash2}{empty}{dash1}{new string(dash3, n - 2)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
