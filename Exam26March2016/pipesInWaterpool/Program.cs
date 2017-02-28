using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipesInWaterpool
{
    class Program
    {
        static void Main(string[] args)
        {
            double waterpoolValue = double.Parse(Console.ReadLine());
            double pipe1ForHour = double.Parse(Console.ReadLine());
            double pipe2ForHour = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double incomeWater = (pipe1ForHour + pipe2ForHour) * hours;


            double percentPipe1 = Math.Floor(((pipe1ForHour * hours) * 100) / incomeWater);
            double percentPipe2 = Math.Floor(((pipe2ForHour * hours) * 100) / incomeWater);


            if (incomeWater <= waterpoolValue)
            {
                double percentWaterPoolFull = Math.Floor((incomeWater * 100) / waterpoolValue);

                Console.WriteLine($"The pool is {percentWaterPoolFull}% full. Pipe 1: {percentPipe1}%. Pipe 2: {percentPipe2}%.");
            }
            else
            {
                double overFlow = incomeWater - waterpoolValue;

                Console.WriteLine($"For {hours} hours the pool overflows with {overFlow} liters.");
            }
        }
    }
}
