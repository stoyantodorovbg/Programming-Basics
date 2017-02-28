using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dayWin = double.Parse(Console.ReadLine());
            double kursDollar = double.Parse(Console.ReadLine());

            var totalYearnInMonth = dayWin * workDays;
            var totalYearnInYear = totalYearnInMonth * 14.5;
            totalYearnInYear =  totalYearnInMonth * 0.75;
            var dailyWinDollars = totalYearnInYear / 365;
            var dailyWinLeva = dailyWinDollars * kursDollar;
            Console.Write($"{dailyWinLeva:F2}");

        }
    }
}
