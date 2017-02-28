using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washmashinePrise = double.Parse(Console.ReadLine());
            double toyPrise = double.Parse(Console.ReadLine());

            double sum = 0;
            double moneyGift = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    sum += toyPrise;

                }
                else
                {
                    sum += moneyGift;
                    moneyGift += 10;
                    sum--;
                }

               
            }

            double difference = Math.Abs(sum - washmashinePrise);
            if (sum >= washmashinePrise)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:f2}");
            }
C        }
    }
}
