using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char a = '/';
            char b = '\\';
            char c = '^';
            char d = '_';
            char e = '|';
            char f = ' ';

            int downDashNumber = 0;

            if (n % 2 != 0)
            {
                downDashNumber = ((n - 3) / 2) * 2;
            }
            else
            {
                downDashNumber = ((n - 4) / 2) * 2;
            }

            Console.Write($"{a}{new string(c, n / 2)}{b}{new string(d, downDashNumber)}{a}{new string(c, n / 2)}{b}");
            Console.WriteLine();

            for (int i = 0; i < n - 3; i++)
            {
                Console.Write($"{e}{new string(f, (2 * n) - 2)}{e}");
                Console.WriteLine();
            }

            Console.Write($"{e}{new string(f, ((2 * n) - 2) / 2 - downDashNumber / 2)}{new string(d, downDashNumber)}{new string(f, ((2 * n) - 2) / 2 - downDashNumber / 2)}{e}");
            Console.WriteLine();

            Console.Write($"{b}{new string(d, n / 2)}{a}{new string(f, downDashNumber)}{b}{new string(d, n / 2)}{a}");
            Console.WriteLine();
        }
    }
}
