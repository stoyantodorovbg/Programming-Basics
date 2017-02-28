using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosto_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive number! ");
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxdivider = (int)Math.Sqrt(number);
            bool prime = true;
            while(prime&&divider<=(maxdivider))
                {
                if(number%divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("It is positive number: " + prime);

        }
    }
}
