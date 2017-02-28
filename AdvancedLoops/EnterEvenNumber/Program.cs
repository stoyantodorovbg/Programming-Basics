using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = 0;
                while (true)
                {
                    Console.WriteLine("Enter even number: ");
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        break;    
                    }
                    Console.WriteLine("The number is not even.");
                }

                Console.WriteLine("Even number enetered: " + n);  

            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }

        }
    }
}
