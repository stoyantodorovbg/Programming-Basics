using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timePlus
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            if (hour >= 1 && hour <= 23 && minutes >= 1 && minutes <= 59)
            {
                DateTime time = ParseExact(hour, minutes)
            }

        }
    }
}
