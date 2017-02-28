using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int series = 0;
            int last = -10000000;
            int bigestSeries = 0;

            for (int i = 0; i < n; i ++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > last)
                {
                    series++;
                }
                else
                {
                    series = 1;
                }
            
                if (series > bigestSeries)
                {
                    bigestSeries = series;
                }

                last = number;
            }

            Console.WriteLine(Math.Max(bigestSeries, series));
        }
    }
}
