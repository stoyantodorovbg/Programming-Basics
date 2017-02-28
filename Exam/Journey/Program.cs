using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal adults = decimal.Parse(Console.ReadLine());
            decimal childs = decimal.Parse(Console .ReadLine());
            decimal nights = decimal.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            decimal transportPrice = 0m; 

        
            if (transport == "train")
            {
                transportPrice = (adults * 24.99m) + (childs * 14.99m);

                if (adults + childs >= 50m)
                {
                    transportPrice -= transportPrice * 0.5m;
                }

            }
            else if (transport == "bus")
            {
                transportPrice = (adults * 32.50m) + (childs * 28.50m);
            }
            else if (transport == "boat")
            {
                transportPrice = (adults * 42.99m) + (childs * 39.99m);
            }
            else if (transport == "airplane")
            {
                transportPrice = (adults * 70.00m) + (childs * 50.00m);
            }

            decimal nightsPrice = nights * 82.99m;
            decimal sumPrice = (transportPrice * 2m) + nightsPrice;
            sumPrice += sumPrice * 0.1m;

            Console.WriteLine(Math.Round(sumPrice, 2));

        }
    }
}
