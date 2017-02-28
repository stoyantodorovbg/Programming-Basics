using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfDiamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var star = "*";
            var kliomba = "@";
            var tire = "-";
            if (number == 3)
            {
                Console.WriteLine(star + star + star);
                Console.WriteLine(star + kliomba + star);
                Console.WriteLine(star + star + star);
            }
            else
            for (var a = 1; a <= number; a ++)
            {
                    {
                        Console.Write(star);
                    }
                    Console.WriteLine();
                 
                    if (a == (number / 2) - 1)
                    {
                        Console.Write(star);
                        for (var m = 1; m <= a; m++)
                        {
                            Console.Write(tire);
                        }
                        for (var m = 1; m <= a; m++)
                        {
                            Console.Write(kliomba);
                        }
                        for (var m = 1; m <= a; m++)
                        {
                            Console.Write(tire);
                        }
                    }
                    if(a == number / 2)
                    {
                        Console.Write(star);
                        for (var n = 1; n <= number - 2; n ++)
                        {
                            Console.Write(kliomba);
                        }
                        Console.Write(star);
                        Console.WriteLine();
                    }
                    if (a == (number / 2) + 1)
                    {
                        Console.Write(star);
                        for (var m = 1; m <= a - 3; m++)
                        {
                            Console.Write(tire);
                        }
                        for (var m = 1; m <= a - 2; m++)
                        {
                            Console.Write(kliomba);
                        }
                        for (var m = 1; m <= a - 3; m++)
                        {
                            Console.Write(tire);
                        }
                    }
                }
            }
        }
    }