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
            int n = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 <= n; i1++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (int i3 = 1; i3 <= n; i3++)
                    {
                        for (int i4 = 1; i4 <= n; i4++)
                        {
                            for (int i5 = 1; i5 <= n; i5++)
                            {
                                for (int i6 = 1; i6 <= n; i6++)
                                {
                                    if (i1 * i2 * i3 * i4 * i5 * i6 == n)
                                    {
                                        Console.Write($"{i1}{i2}{i3}{i4}{i5}{i6} ");
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
