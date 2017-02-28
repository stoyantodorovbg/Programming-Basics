using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var weekendsInTheCountry = double.Parse(Console.ReadLine());
            var gamesInTheHolidays = (holidays * 2) / 3;
            var gamesInSofia = ((48 - weekendsInTheCountry) * 3) / 4;
            var games = weekendsInTheCountry + gamesInSofia + gamesInTheHolidays;
            if (year == "leap")
            {
                games = games + (games * 0.15);
            }
            Console.WriteLine(Math.Floor(games));
        }
    }
}
