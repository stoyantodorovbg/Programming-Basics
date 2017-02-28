using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            char l = char.Parse(Console.ReadLine());

            var point = 4;

            for (var row = 0; row < 999; row ++)
            {
                if (row == n)
                {
                    break;
                }
                
                point--;
                Console.Write(new string('.', point));
                for (var a = l; a <= 7; a ++)
            {
                    Console.Write(a);
            }
                Console.Write(new string('.', point));
                if (point == 0)
                    {
                        point++;
                    }
                if (point == 4)
                {
                    point--;
                }
                Console.WriteLine();
            }
        }
    }
}
