using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = decimal.Parse(Console.ReadLine());
            var totalPrice = 0m;
            if (day == "monday" || day == "tuesday" || day == "wednesday" ||
                day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    totalPrice = quantity * 2.50m;
                }
                else if (fruit == "apple")
                {
                    totalPrice = quantity * 1.20m;
                }
                else if (fruit == "orange")
                {
                    totalPrice = quantity * 0.85m;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = quantity * 1.45m;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = quantity * 2.70m;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = quantity * 5.50m;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = quantity * 3.85m;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    totalPrice = quantity * 2.70m;
                }
                else if (fruit == "apple")
                {
                    totalPrice = quantity * 1.25m;
                }
                else if (fruit == "orange")
                {
                    totalPrice = quantity * 0.90m;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = quantity * 1.60m;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = quantity * 3.00m;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = quantity * 5.60m;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = quantity * 4.20m;
                }
            }
            if (totalPrice > 0 )
            {
                Console.WriteLine(Math.Round(totalPrice, 2));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
