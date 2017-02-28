using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var firstDigit = number / 100;
            var secondDigit = number % 100 / 10;
            var thirdDigit = number % 10;
         

           

            for (int row = 0; row < firstDigit + secondDigit; row++)
            {
                for (int col = 0; col < firstDigit + thirdDigit; col ++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else

                    {
                        number += thirdDigit;
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            } 


        }
    }
}
