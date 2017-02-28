using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double allMoney = double.Parse(Console.ReadLine());
            double lastYear = double.Parse(Console.ReadLine());

            double years = lastYear - 1799;
            double spendedMoney = 0;

            for (int year = 0; year < years; year ++)
            {
                if (year %  2 != 0)
                {
                    spendedMoney += 12000 + (50 * (18 + year));
                }
                else
                {
                    spendedMoney += 12000;
                }
            }

            double difference = Math.Abs(spendedMoney - allMoney);

            if (spendedMoney <= allMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {difference:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {difference:F2} dollars to survive.");
            }

        }
    }
}
