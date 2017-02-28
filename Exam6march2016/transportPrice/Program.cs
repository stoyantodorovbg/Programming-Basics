using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double price = 0D; 

            if (km < 20D)
            {
                
                if (time == "day")
                {
                    price = 0.79D * km;
                }
                else if (time == "night")
                {
                    price = 0.90D * km;
                }

                price += 0.70D;
            }
            else if(km >= 20D && km < 100D)
            {
                price = 0.09D * km;
            }
            else if (km >= 100D)
            {
                price = 0.06D * km; 
            }

            Console.WriteLine(price);
        }
    }
}
