using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalCouples
{
    class Program
    {
        static void Main(string[] args)
        {
            var couples = double.Parse(Console.ReadLine());
            var sumCouple = 0d;
            var sumOfAll = 0d;
            var keepSumCouple = 0d;
            var keepDiff = 0d;
            var diff = 0d;
            var max = -1000000000.0;
            for (var i = 0; i < couples; i++)
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                sumCouple = first + second;
                if (keepSumCouple != 0)
                {
                    diff = keepSumCouple - sumCouple;
                }
                keepSumCouple = sumCouple;
                keepDiff = Math.Abs(diff);
                sumOfAll += sumCouple;
                if(keepDiff > max)
                {
                    max = keepDiff;
                }
            }
            if (sumOfAll / couples == sumCouple)
            {
                Console.WriteLine("Yes, value={0}", sumCouple);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", Math.Abs(max));
            }
        }
    }
}
