using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingFourNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var n = Math.Abs(a - b);
            var min = Math.Min(a, b);
            var max = Math.Max(a, b);
            if (n < 3)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (var i1 = min; i1 <= max; i1++)
                {
                    for (var i2 = i1; i2 <= max; i2++)
                    {
                        for (var i3 = i2; i3 <= max; i3++)
                        {
                            for (var i4 = i3; i4 <= max; i4++)
                            {
                                if (i1 < i2 && i2 < i3 && i3 < i4)
                                {

                                    Console.WriteLine(i1);
                                    Console.WriteLine(i2);
                                    Console.WriteLine(i3);
                                    Console.WriteLine(i4);

                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
