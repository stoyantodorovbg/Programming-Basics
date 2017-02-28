using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleOfNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var a = 0; a < n; a++)
            {
                for ( var b = 0; b < n; b ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
