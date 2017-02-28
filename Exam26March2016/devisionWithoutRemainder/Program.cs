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

            double count1 = 0;
            double count2 = 0;
            double count3 = 0;

            double n1 = 0;
            double n2 = 0;
            double n3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count1++;
                }
                if (number % 3 == 0)
                {
                    count2++;
                }
                if (number % 4 == 0)
                {
                    count3++;
                }
            }

            n1 = (count1 / n) * 100;
            n2 = (count2 / n) * 100;
            n3 = (count3 / n) * 100;

            Console.WriteLine($"{n1:F2}%");
            Console.WriteLine($"{n2:F2}%");
            Console.WriteLine($"{n3:F2}%");
        }
    }
}
