using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());
            double dogDayFood = double.Parse(Console.ReadLine());
            double catDayFood = double.Parse(Console.ReadLine());
            double turtleDayFood = double.Parse(Console.ReadLine());

            double allFoodDog = dogDayFood * days;
            double allCatFood = catDayFood * days;
            double allTurtleFood = (turtleDayFood * days) / 1000d;

            double allEatFood = allFoodDog + allCatFood + allTurtleFood;

            double difference = Math.Abs(allEatFood - allFood);

            if (allFood >= allEatFood)
            {
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
            }


        }
    }
}
