using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            double l1 = 0;
            double l2 = 0;
            double l3 = 0;
            double l4 = 0;
            double l5 = 0;


            for (int i = 0; i < n; i ++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 200)
                {
                    l1 ++;
                }
                else if (number >= 200 && number < 400)
                {
                    l2 ++;
                }
                else if (number >= 400 && number < 600)
                {
                    l3 ++;
                }
                else if (number >= 600 && number < 800)
                {
                    l4 ++;
                }
                else if (number >= 800)
                {
                    l5 ++;
                }

            }

            p1 = Math.Round(l1 / n * 100, 2);
            p2 = Math.Round(l2 / n * 100, 2);
            p3 = Math.Round(l3 / n * 100, 2);
            p4 = Math.Round(l4 / n * 100, 2);
            p5 = Math.Round(l5 / n * 100, 2);

            Console.WriteLine(p1 + "%");
            Console.WriteLine(p2 + "%");
            Console.WriteLine(p3 + "%");
            Console.WriteLine(p4 + "%");
            Console.WriteLine(p5 + "%");

        }
    }
}
