using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (var row = 0; row < n / 2; row ++)
                {
                        Console.Write(new string('-', ((n / 2) - 1) - row));
                        Console.Write(new string('*', (2 * row) + 2));
                        Console.Write(new string('-', ((n / 2) - 1) - row));
                        Console.WriteLine();
                }

                for (var row = 0; row < n / 2; row ++)
                {
                    Console.Write('|');
                    Console.Write(new string('*', n - 2));
                    Console.Write('|');
                    Console.WriteLine();
                }
            }
            else
            {
                n ++; 

                for (var row = 0; row < (n / 2) ; row++)
                {
                    Console.Write(new string('-', ((n / 2) - 1) - row));
                    Console.Write(new string('*', (2 * row) + 1));
                    Console.Write(new string('-', ((n / 2) - 1) - row));
                    Console.WriteLine();

                }
 
                n -= 2;

                for (var row = 0; row < n / 2; row++)
                {
                    Console.Write('|');
                    Console.Write(new string('*', n - 1));
                    Console.Write('|');
                    Console.WriteLine();
                }

            }
        }
    }
}
