using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusTochki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter skore: ");
            var score = double.Parse(Console.ReadLine());
            var totalScore = score;
            if (score <= 100)
            {
                totalScore += 5;
            }
            else if (score > 100 && score <= 1000)
            {
                totalScore += (score * 0.20d);
            }
            else if (score > 1000)
            {
                totalScore += score * 0.10d;
            }
            if (score % 2 == 0)
            {
                totalScore += 1;
            }
            else if (score % 10 == 5)
            {
                totalScore += 2;
            }
            var bonusScore = totalScore - score;
            Console.WriteLine("Bonus score: " + bonusScore);
            Console.WriteLine("Total score: " + totalScore);
        }
    }
}
