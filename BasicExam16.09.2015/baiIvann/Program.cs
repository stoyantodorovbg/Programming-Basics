using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiIvann
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            decimal desiredAlcohol = decimal.Parse(Console.ReadLine());

            decimal drunkAlcohol = 0;

            if (day == 0)
            {
                drunkAlcohol = money / 25.0m;
            }
            else if (day == 1)
            {
                drunkAlcohol = money / 21.0m;
            }
            else if (day == 1)
            {
                drunkAlcohol = money / 14.0m;
            }
            else if (day == 3)
            {
                drunkAlcohol = money / 17.0m;
            }
            else if (day == 4)
            {
                drunkAlcohol = money / 45.0m;
            }
            else if (day == 5)
            {
                drunkAlcohol = money / 59.0m;
            }
            else if (day == 6)
            {
                drunkAlcohol = money / 42.0m;
            }

            string condition = null;

            if (drunkAlcohol > 1.5m)
            {
                condition = "very drunk";
            }
            else if (drunkAlcohol >= 1.0m && drunkAlcohol <= 1.5m)
            {
                condition = "drunk";
            }
            else if (drunkAlcohol < 1.0m)
            {
                condition = "sober";
            }

            decimal difference = Math.Abs(drunkAlcohol - desiredAlcohol);

            if (drunkAlcohol > desiredAlcohol)
            {
                Console.WriteLine($"Bai Ivan is {condition} and very happy and he shared {difference:F2} l. of alcohol with his friends");
            }
            else if (drunkAlcohol == desiredAlcohol)
            {
                Console.WriteLine($"Bai Ivan is {condition} and happy. He is as drunk as he wanted");
            }
            else
            {
                Console.WriteLine($"Bai Ivan is {condition} and quite sad. He wanted to drink another {difference:F2} l. of alcohol");
            }

        }
    }
}
