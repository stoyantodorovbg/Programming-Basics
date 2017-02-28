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
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string(' ', n + 1));
            Console.Write('|');
            Console.WriteLine();
            for (var row = 0; row < n; row ++)
            {
                Console.Write(new string(' ', n - (row + 1)));
                Console.Write(new string('*', row + 1));
                Console.Write(' ');
                Console.Write('|');
                Console.Write(' ');
                Console.Write(new string('*', row + 1));
                Console.WriteLine();
            }
        }
    }
}
