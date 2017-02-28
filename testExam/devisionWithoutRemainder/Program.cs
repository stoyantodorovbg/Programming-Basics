using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }

                if (number % 3 == 0)
                {
                    p2++;
                }

                if (number % 4 == 0)
                {
                    p3++;
                }
            }

            double percentP1 = (p1 * 100) / n;
            double percentP2 = (p2 * 100) / n;
            double percentP3 = (p3 * 100) / n;

            Console.WriteLine($"{percentP1:F2}%");
            Console.WriteLine($"{percentP2:F2}%");
            Console.WriteLine($"{percentP3:F2}%");
        }
    }
}
