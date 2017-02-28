using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (var row = 0; row < n - 1; row ++)
            {
                for (var sp = 0; sp < n - (row + 1); sp ++)
                {
                    Console.Write(' ');
                }
                for (var col = 0; col < n - (n - (row + 1)); col ++ )
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
       
            for ( var col = 0; col < n; col ++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

           for (var row = 0; row < n - 1; row ++)
            {
                for (var sp = 0; sp < n - (n - (row + 1)); sp ++)
                {
                    Console.Write(' ');
                }
                for (var col = 0; col < n - (row + 1); col ++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
