using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDigit = 0;
            int secondDigit = 0;
            int tirdDigit = 0;
            int fourthDigit = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                firstDigit = i / 1000;
                secondDigit = (i / 100) % 10;
                tirdDigit = (i / 10) % 10;
                fourthDigit = i % 10;
                if (fourthDigit != 0 && secondDigit != 0 && tirdDigit != 0 && fourthDigit != 0)
                {
                    if (n % firstDigit == 0 && n % secondDigit == 0 && n % tirdDigit == 0 && n % fourthDigit == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
