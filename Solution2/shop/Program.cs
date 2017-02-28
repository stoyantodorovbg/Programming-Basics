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
                if (product == "cofee")
                {
                    Console.WriteLine(quantity * 0.50m);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.80m);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.20m);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45m);

                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.60m);
                }

                if (town == "Plovdiv")
                {
                    if (product == "cofee")
                    {
                        Console.WriteLine(quantity * 0.40m);

                    }
                    if (product == "water")
                    {
                        Console.WriteLine(quantity * 0.70m);
                    }
                    if (product == "beer")
                    {
                        Console.WriteLine(quantity * 1.15m);
                    }
                    if (product == "sweets")
                    {
                        Console.WriteLine(quantity * 1.30m);
                    }
                    if (product == "peanuts")
                    {
                        Console.WriteLine(quantity * 1.50m);
                    }
                    if (town == "Varna")
                    {
                        if (product == "cofee")
                        {
                            Console.WriteLine(quantity * 0.45m);
                        }
                        if (product == "water")
                        {
                            Console.WriteLine(quantity * 0.70m);
                        }
                        if (product == "beer")
                        {
                            Console.WriteLine(quantity * 1.10m);
                        }
                        if (product == "sweets")
                        {
                            Console.WriteLine(quantity * 1.35m);
                        }
                        if (product == "peanuts")
                        {
                            Console.WriteLine(quantity * 1.55m);
                        }
                    }
                }
            }
        }
    }
}


