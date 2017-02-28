using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTicoon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal expectedCakes = decimal.Parse(Console.ReadLine());
            decimal neededFlourforOneKake = decimal.Parse(Console.ReadLine());
            decimal availableFlour = decimal.Parse(Console.ReadLine());
            decimal availableTruffels = decimal.Parse(Console.ReadLine());
            decimal priceTruffels = decimal.Parse(Console.ReadLine());

            decimal cakes = Math.Floor(availableFlour / neededFlourforOneKake);
            decimal priceOfAllCakes = availableTruffels * priceTruffels;
            decimal priceOfOneCake = priceOfAllCakes / expectedCakes;
            decimal priceOfAllCakes = Math.Floor(priceOfOneCake * cakes, 2);
            decimal neededFlour = ((availableFlour / neededFlourforOneKake) - cakes) + expectedCakes * neededFlourforOneKake;

            if (cakes >= expectedCakes)
            {
                Console.WriteLine($"All products available, price of a cake: {priceOfAllCakes}");
            }
            else
            {
                Console.WriteLine($"Can make only {cakes} cakes, need {neededFlourforOneKake} kg more flour");
            }
        }
    }
}
