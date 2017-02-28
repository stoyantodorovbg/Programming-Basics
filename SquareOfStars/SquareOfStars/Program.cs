using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string space = " ";
            string star = "*";
            string emptySpace = "";
            for (int a = 1; a <= number; a ++)
            {
                Console.Write(star);
            }
            Console.WriteLine(emptySpace);
            for (int b = 1; b <= number - 2; b ++)
            {
                Console.Write(star);
                for (int c = 1; c <= number - 2; c ++)
                {
                    Console.Write(space);
                }
                Console.WriteLine(star);
            }
            for (int d = 1; d <= number; d ++)
                {
                Console.Write(star);
                }  
        }
    }
}
