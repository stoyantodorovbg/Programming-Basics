using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayWin
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDaysInMay = decimal.Parse(Console.ReadLine());
            var dayWinDollars = decimal.Parse(Console.ReadLine());
            var excangeRate = decimal.Parse(Console.ReadLine());
            var mayWinDollars = dayWinDollars * workDaysInMay;
            var yearWinDollars = (((mayWinDollars * 12m) + (mayWinDollars * 2.5m)) -
                (((mayWinDollars * 12m) + (mayWinDollars * 2.5m)) * 0.25m));
            var dayWinLeva = (yearWinDollars / 365m) * excangeRate;
            Console.WriteLine(Math.Round(dayWinLeva, 2));
        }
    }
}
