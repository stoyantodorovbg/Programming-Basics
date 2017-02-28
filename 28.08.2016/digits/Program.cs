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

            int first = number / 100;
            int second = (number / 10) % 10;
            int third = number % 10;

            
           

            for (int row = 0; row < first + second; row++)
            {
                for (int col = 0; col < first + third; col++)
                {
                    if (number % 5 == 0)
                    {
                        number -= first;
                        Console.Write("{0} ", number);
                    }

                    else if (number % 3 == 0)
                    {
                        number -= second;
                        Console.Write("{0} ", number);
                    }

                    else
                    {
                        number += third;
                        Console.Write("{0} ", number);
                    }
                    
                }

                Console.WriteLine();
            }
        

        }
    }
}
