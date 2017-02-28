using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var digit = 1;
            var sum = 0;

            while(digit != 0)
            {
               digit = n % 10;
                n = n / 10;
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
