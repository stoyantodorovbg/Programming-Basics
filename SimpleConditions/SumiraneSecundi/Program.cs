using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumiraneSecundi
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            var minutes = 0;
            var seconds = 0;
            if (first >= 1 && first <= 50 && second >= 1 && second <=50 && third >= 1 && third <=50)
            {
                var sum = first + second + third;
                if (sum > 0 && sum <= 59)
                {
                    minutes = 0;
                }
                else if (sum >= 60 && sum <= 119)
                {
                    minutes = 1;
                }
                else if (sum >= 120 && sum <= 179)
                {
                    minutes = 2;
                }
                if (minutes == 0)
                {
                    seconds = sum;
                }
                else if (minutes == 1)
                {
                    seconds = sum - 60;
                }
                else if (minutes == 2)
                {
                    seconds = sum - 120;
                }
                if (seconds >= 10)
                {
                    Console.WriteLine(minutes + ":" + seconds);
                }
                else if (seconds < 10)
                {
                    Console.WriteLine(minutes + ":0" + seconds);
                }
            }
        }
    }
}
