using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (var a1 = 1; a1 <= 9; a1++)
            {
                for (var a2 = 1; a2 <= a1; a1++)
                {
                    for (var a3 = 1; a3 <= a2; a3++)
                    {
                        for (var a4 = 1; a4 <= a3; a4++)
                        {
                            for (var a5 = 1; a5 <= a4; a5++)
                            {
                                for (var a6 = 1; a6 <= a5; a6++)
                                {
                                    if (a1 * a2 * a3 * a3 * a4 * a5 * a6 == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", a1, a2, a3, a4, a5, a6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

