using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var people = decimal.Parse(Console.ReadLine());
            var transport = 1m;
            var budgetForMan = 1m;
            var restMoney = 1m;
            if (people > 0 && people <= 4)
            {
                transport = budget * 0.75m;
            }
            else if (people > 4 && people <= 9)
            {
                transport = budget * 0.60m;
            }
            else if (people > 9 && people <= 24)
            {
                transport = budget * 0.50m;
            }
            else if (people > 24 && people <= 49)
            {
                transport = budget * 0.40m;
            }
            else if ( people > 50)
            {
                transport = budget * 0.25m;
            }
            if (category == "VIP")
            {
                budgetForMan = (budget - transport) / people; 
                if (budgetForMan >= 499.99m)
                {
                    restMoney = (budgetForMan - 499.99m) * people;
                    Console.WriteLine("Yes! You have {0:f2} leva left.", restMoney);
                }
                else
                {
                    restMoney = (budgetForMan - 499.99m) * people;
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(restMoney));
                }
            }
            if (category == "Normal")
            {
                budgetForMan = (budget - transport) / people;
                if (budgetForMan > 249.99m)
                {
                    restMoney = (budgetForMan - 249.99m) * people;
                    Console.WriteLine("Yes! You have {0:f2} leva left.", restMoney);
                }
                else
                {
                    restMoney = (budgetForMan - 249.99m) * people;
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(restMoney));
                }
            }
        }
    }
}
