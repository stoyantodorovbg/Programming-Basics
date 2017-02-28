using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());

            double incomeLeva = (vegetablePrice * vegetables) + (fruitPrice * fruits);
            double incomeEuro = incomeLeva / 1.94d;

            Console.WriteLine(incomeEuro);


        }
    }
}
