using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var spendedMoney = 0m;
            if (budget <= 100.00m)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    spendedMoney = budget * 0.30m;
                    Console.WriteLine("Camp - " + Math.Round(spendedMoney, 2));
                }
                else if (season == "winter")
                {
                    spendedMoney = budget * 0.70m;
                    Console.WriteLine("Hotel - " + Math.Round(spendedMoney, 2));
                }
            }
            else if (budget <= 1000.00m)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    spendedMoney = budget * 0.40m;
                    Console.WriteLine("Camp - " + Math.Round(spendedMoney, 2));
                }
                else if (season == "winter")
                {
                    spendedMoney = budget * 0.80m;
                    Console.WriteLine("Hotel - " + Math.Round(spendedMoney, 2));
                }
            }
            else if (budget > 1000)
            {
                spendedMoney = budget * 0.90m;
                Console.WriteLine("Somewhere in Europe" );
                Console.WriteLine("Hotel - " + Math.Round(spendedMoney, 2));
            }
        }
    }
}
