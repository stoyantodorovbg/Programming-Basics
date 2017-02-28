using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timePlusFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            {
                minute += 15;
                if (minute > 59)
                {
                    hour++;
                    minute -= 60;
                }
                if (hour > 23)
                {
                    hour -= 24;
                }
                if (minute <= 9)
                {
                    Console.WriteLine("{0}:0{1}", hour, minute);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hour, minute);
                }
            }
        }
    }
}
