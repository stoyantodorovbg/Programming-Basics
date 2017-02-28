using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double men = double.Parse(Console.ReadLine());

            double budgetForTransport = 0;

            if (men <= 4)
            {
                budgetForTransport = budget * 0.75d;
            }
            else if (men > 4 && men <= 9)
            {
                budgetForTransport = budget * 0.6d;
            }
            else if (men > 9 && men <= 24)
            {
                budgetForTransport = budget * 0.5d;
            }
            else if (men > 24 && men <= 49)
            {
                budgetForTransport = budget * 0.4d;
            }
            else if (men > 49)
            {
                budgetForTransport = budget * 0.25d;
            }

            double budgetForTickets = budget - budgetForTransport;
            double needBudgetForTickets = 0;

            if (category == "VIP")
            {
                needBudgetForTickets = men * 499.99d;
            }
            else if (category == "Normal")
            {
                needBudgetForTickets = men * 249.99d;
            }

            double difference = Math.Abs(needBudgetForTickets - budgetForTickets);

            if (needBudgetForTickets <= budgetForTickets)
            {
                Console.WriteLine($"Yes! You have {difference:F2} leva left.");
            }
            if (needBudgetForTickets > budgetForTickets)
            {
                Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
            }
        }
    }
}
