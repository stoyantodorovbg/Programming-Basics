using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var number = 1;
            var firstNumber = 1;
            var secondNumber = 1;

            if (n >= 2)
            {
                for (var a = 0; a < n - 1; a++)
                {
                    
                    number = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = number;

                }
            }

                Console.WriteLine(number);
        }
    }
}
