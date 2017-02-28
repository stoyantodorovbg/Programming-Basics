using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1 - i));
                Console.Write('*');

                for (int e = 0; e < i; e ++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', i + 1));
                Console.Write('*');

                for (int e = n - 2 - i; e > 0; e--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
