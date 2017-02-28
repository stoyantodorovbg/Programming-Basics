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
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double passings = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    passings = (budget * 30) / 100;
                    Console.WriteLine($"Camp - {passings:F2}");
                }
                else if (season == "winter")
                {
                    passings = (budget * 70) / 100;
                    Console.WriteLine($"Hotel - {passings:F2}");
                }

            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (season == "summer")
                {
                    passings = (budget * 40) / 100;
                    Console.WriteLine($"Camp - {passings:F2}");
                }
                else if (season == "winter")
                {
                    passings = (budget * 80) / 100;
                    Console.WriteLine($"Hotel - {passings:F2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");

                passings = (budget * 90) / 100;
                Console.WriteLine($"Hotel - {passings:F2}");
            }

        }
    }
}
