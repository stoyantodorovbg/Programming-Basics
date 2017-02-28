using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGariefield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            decimal exchangeRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            pizzaPrice /= exchangeRate;
            lasagnaPrice /= exchangeRate;
            sandwichPrice /= exchangeRate;

            decimal spendedSum = pizzaPrice * pizzaQuantity + lasagnaPrice * lasagnaQuantity + 
                sandwichPrice * sandwichQuantity;

            decimal difference = Math.Abs(sum - spendedSum);

            if (sum >= spendedSum)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${difference:F2}.");
            }
            else
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${difference:F2}.");
            }

        }
    }
}
