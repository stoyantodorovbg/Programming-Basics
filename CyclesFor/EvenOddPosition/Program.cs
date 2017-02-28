using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var keepSumOdd = 0d;
            var keepSumEven = 0d;
            var maxOdd = -1000000000.0;
            var maxEven = -1000000000.0;
            var minOdd = 1000000000.0;
            var minEven = 1000000000.0;
            for (var i = 1; i <= n; i++ )
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    keepSumOdd += number;
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                
                }
                else if (i % 2 == 0)
                {
                    keepSumEven += number;
                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                    if (number < minEven)
                    {
                        minEven = number;
                    }
                }

            }
            if ((minOdd == 1000000000.0 && maxOdd == -1000000000.0) &&
                (maxEven == -1000000000.0 && minEven == 1000000000.0))
            {
                Console.WriteLine("OddSum={0},", keepSumOdd);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0},", keepSumEven);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if ((minOdd == 1000000000.0 && maxOdd == -1000000000.0))
            {
                Console.WriteLine("OddSum={0},", keepSumOdd);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0},", keepSumEven);
                Console.WriteLine("EvenMin={0},", minEven);
                Console.WriteLine("EvenMax={0}", maxEven);
            }
            else if ((maxEven == -1000000000.0 && minEven == 1000000000.0))
            {
                Console.WriteLine("OddSum={0},", keepSumOdd);
                Console.WriteLine("OddMin={0},", minOdd);
                Console.WriteLine("OddMax={0},", maxOdd);
                Console.WriteLine("EvenSum={0},", keepSumEven);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if ((minOdd == 1000000000.0 && maxOdd == -1000000000.0) || 
                (maxEven == -1000000000.0 && minEven == 1000000000.0))
            {
                Console.WriteLine("OddSum={0},", keepSumOdd);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0},", keepSumEven);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("OddSum={0},", keepSumOdd);
                Console.WriteLine("OddMin={0},", minOdd);
                Console.WriteLine("OddMax={0},", maxOdd);
                Console.WriteLine("EvenSum={0},", keepSumEven);
                Console.WriteLine("EvenMin={0},", minEven);
                Console.WriteLine("EvenMax={0}", maxEven);
            }
        }
    }
}
