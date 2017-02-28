using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine('*');
            }
            else
            {

                if (n % 2 == 0)
                {
                    for (var row = 0; row < n / 2; row++)
                    {
                        Console.Write(new string('-', (n / 2) - (row + 1)));
                        Console.Write('*');
                        Console.Write(new string('-', row * 2));
                        Console.Write('*');
                        Console.Write(new string('-', (n / 2) - (row + 1)));
                        Console.WriteLine();
                    }

                    for (var row = 0; row < n / 2 - 1; row++)
                    {
                        Console.Write(new string('-', 1 + row));
                        Console.Write('*');
                        Console.Write(new string('-', (n - 4) - (2 * row)));
                        Console.Write('*');
                        Console.Write(new string('-', 1 + row));
                        Console.WriteLine();
                    }
                }
                else
                {

                    Console.Write("{0}*{2}", new string('-', n / 2), '*', new string('-', n / 2));
                    Console.WriteLine();

                    for (var row = 0; row < n / 2; row++)
                    {
                        Console.Write(new string('-', (n / 2) - (row + 1)));
                        Console.Write('*');
                        Console.Write(new string('-', (row * 2 + 1)));
                        Console.Write('*');
                        Console.Write(new string('-', (n / 2) - (row + 1)));
                        Console.WriteLine();
                    }

                    for (var row = 0; row < n / 2 - 1; row++)
                    {
                        Console.Write(new string('-', 1 + row));
                        Console.Write('*');
                        Console.Write(new string('-', (n - 4) - (2 * row)));
                        Console.Write('*');
                        Console.Write(new string('-', 1 + row));
                        Console.WriteLine();
                    }

                    Console.Write("{0}*{2}", new string('-', n / 2), '*', new string('-', n / 2));
                }
            }
        }
    }
}
