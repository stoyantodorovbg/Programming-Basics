using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            double groups = double.Parse(Console.ReadLine());

            double byCar = 0;
            double byMicrobus = 0;
            double byMinibus = 0;
            double byBus = 0;
            double byTrain = 0;
            double sumPeople = 0;

     
            for (int i = 0; i < groups; i++)
            {
                double peopleInGroup = double.Parse(Console.ReadLine());

                if (peopleInGroup <= 5)
                {
                    byCar += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    byMicrobus += peopleInGroup;
                }
                else if (peopleInGroup >=13 && peopleInGroup <= 25)
                {
                    byMinibus += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    byBus += peopleInGroup;
                }
                else if (peopleInGroup >=41)
                {
                    byTrain += peopleInGroup;
                }

                sumPeople += peopleInGroup;

            }

           

            double percentByCar = (byCar * 100) / sumPeople;
            double percentByMicrobus = (byMicrobus * 100) / sumPeople;
            double percentByMinibus = (byMinibus * 100) / sumPeople;
            double percentByBus = (byBus * 100) / sumPeople;
            double percentByTrain = (byTrain * 100) / sumPeople;

            Console.WriteLine($"{percentByCar:F2}%");
            Console.WriteLine($"{percentByMicrobus:F2}%");
            Console.WriteLine($"{percentByMinibus:F2}%");
            Console.WriteLine($"{percentByBus:F2}%");
            Console.WriteLine($"{percentByTrain:F2}%");
        }
    }
}
