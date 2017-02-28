using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            var price = 0.0;
            if (km >= 1 && km <= 5000)
            {
             
                if (time == "day" && km < 20)
                {
                    price = (km * 0.79) + 0.70; 
                }
                else if (time == "night" && km < 20)
                {
                    price = (km * 0.90) + 0.70;
                }
                else if (km >= 20 && km < 100)
                {
                    price = km * 0.09;
                }
                else if (km >= 100)
                {
                    price = km * 0.06;
                }
                Console.WriteLine(Math.Round(price,2));
            }
        }
    }
}

