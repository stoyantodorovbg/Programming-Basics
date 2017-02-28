using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var left = Math.Min(first, second);
            var right = Math.Max(first, second);
            var leftDistance = Math.Abs(point - left);
            var rightDistance = Math.Abs(right - leftDistance);
            var shortDistance = Math.Min(leftDistance, rightDistance);

            if (point >=  left && point <= second)
            {
                Console.WriteLine("in");
                Console.WriteLine(shortDistance);

               
            }
            else if (point >= left && point <= second)
            {
                Console.WriteLine("out");
                Console.WriteLine(shortDistance);


            }
        }
    }
}
