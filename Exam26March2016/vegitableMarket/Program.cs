using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegitableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegitable = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            double allVegitables = double.Parse(Console.ReadLine());
            double allFruits = double.Parse(Console.ReadLine());

            double priceAllVegitables = priceVegitable * allVegitables;
            double priceAllFruits = priceFruit * allFruits;

            priceAllVegitables /= 1.94;
            priceAllFruits /= 1.94;

            double totalIncomes = priceAllVegitables + priceAllFruits;

            Console.WriteLine(totalIncomes);


        }
    }
}
