using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elementEqualToTheRest
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;
            for (var i = 0; i < n; i ++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                sum += number;
            }
            var half = sum - max;
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                
                Console.WriteLine("Sum = " + half);
            }
            else
            {
                Console.WriteLine("No");
                var diff = max - half;
                Console.WriteLine("Diff = " + Math.Abs(diff));
            }
        }
    }
}
