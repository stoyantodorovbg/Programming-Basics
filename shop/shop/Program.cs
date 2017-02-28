using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = decimal.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.50m);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.80m);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.20m);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45m);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.60m);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.40m);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70m);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15m);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.30m);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.50m);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45m);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70m);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.10m);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35m);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55m);
                }
            }
        }
    }
}

