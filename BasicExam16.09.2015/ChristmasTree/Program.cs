using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write($"{new string('\'', n - i)}{new string('^', (2 * i) + 1)}{new string('\'', n - i)}");
                Console.WriteLine();
                
            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write($"{new string('\'', n - (i + 1))}{new string('^', (2 * i) + 3)}{new string('\'', n - (i + 1))}");
                Console.WriteLine();

            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {

                Console.Write($"{new string('\'', n - 1)}| |{new string('\'', n - 1)}");
                Console.WriteLine();
            }

            Console.Write($"{new string('-', 2 * n + 1)}");
    
        }
    }
}
