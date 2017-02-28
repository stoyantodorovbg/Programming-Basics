using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstDigit = 0;
            var secondDigit = 0;
            var thirdDigit = 0;
            var fourthDigit = 0;
            var one = false;
            var two = false;
            var three = false;
            var four = false;

            for (var number = 1111; number <= 9999; number++)
            {
                fourthDigit = number % 10;
               
                    if (fourthDigit != 0 && n % fourthDigit == 0 && fourthDigit <= n)
                    {
                        four = true;
                    }

                else
                {
                    four = false;
                }

                var third = number / 10;
                thirdDigit = third % 10;
                
                    if (thirdDigit != 0 && n % thirdDigit == 0 && thirdDigit <= n)
                    {
                        three = true;
                    }
                
                else
                {
                    three = false;
                }

                var second = third / 10;
                secondDigit = second % 10;

                    if (secondDigit != 0 && n % secondDigit == 0 && secondDigit <= n)
                    {
                        two = true;
                    }
                
                else
                {
                    two = false;
                }

                var first = second / 10;
                firstDigit = first % 10;
                
                    if (firstDigit != 0 && n % firstDigit == 0 && firstDigit <= n)
                    {
                        one = true;
                    }
                
                else
                {
                    one = false;
                }

                if (one == true && two == true && three == true && four == true)
                {
                    Console.Write("{0}{1}{2}{3} ", firstDigit, secondDigit, thirdDigit, fourthDigit);
                }


            }

        }
    }
}
