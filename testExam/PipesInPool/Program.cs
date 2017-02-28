using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double poolValue = double.Parse(Console.ReadLine());
            double pipe1ForHour = double.Parse(Console.ReadLine());
            double pipe2ForHour = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double incomeWater = (pipe1ForHour + pipe2ForHour) * hours;

            double percentPipe1 = (pipe1ForHour * hours * 100) / incomeWater;
            double percentPipe2 = (pipe2ForHour * hours * 100) / incomeWater;
            double percentAllWater = (incomeWater * 100) / poolValue;
            double overFlow = incomeWater - poolValue;

            if (incomeWater <= poolValue)
            {
                Console.WriteLine($"The pool is {Math.Floor(percentAllWater)}% full. Pipe 1: {Math.Floor(percentPipe1)}%. Pipe 2: {Math.Floor(percentPipe2)}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {overFlow} liters.");
            }

        }
    }
}
