using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayWin
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal workDayInMonth = decimal.Parse(Console.ReadLine());
            decimal dayWin = decimal.Parse(Console.ReadLine());
            decimal exchangeRate = decimal.Parse(Console.ReadLine());

            decimal monthWin = workDayInMonth * dayWin;
            decimal yearWin = (monthWin * 12m) + (2.5m * monthWin);
            decimal realYearWin = yearWin - (yearWin * 0.25m);
            decimal realDayWin = realYearWin / 365m;
            decimal realDayWinInLeva = Math.Round(realDayWin * exchangeRate, 2);

            Console.WriteLine(realDayWinInLeva);


        }
    }
}
