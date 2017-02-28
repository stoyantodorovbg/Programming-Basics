using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stupidPassportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int i1 = 1; i1 <= n; i1++)
                {
                    for (char a = 'a'; a < 'a' + l; a++)
                    {
                        for (char a1 = 'a'; a1 < 'a' + l; a1++)
                        {
                         
                            for (int i2 = Math.Max(i1, i) + 1; i2 <= n; i2++)
                            {
                                Console.Write($"{i}{i1}{a}{a1}{i2} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
