using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operationsWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            var operatora = Console.ReadLine();
            string count = null;

            double result = 0;
            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (operatora == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    count = "even";
                }
                else
                {
                    count = "odd";
                }
                Console.WriteLine($"{n1} {operatora} {n2} = {result} - {count}");
            }
            else if (operatora == "-")
            {
                result = n1 - n2;

                if (result % 2 == 0)
                {
                    count = "even";
                }
                else
                {
                    count = "odd";
                }

                Console.WriteLine($"{n1} {operatora} {n2} = {result} - {count}");
            }
            else if (operatora == "*")
            {
                result = n1 * n2;

                if (result % 2 == 0)
                {
                    count = "even";
                }
                else
                {
                    count = "odd";
                }

                Console.WriteLine($"{n1} {operatora} {n2} = {result} - {count}");
            }
            else if (operatora == "/")
            {
                result = n1 / n2;

                Console.WriteLine($"{n1} {operatora} {n2} = {result:f}");
            }
            else if (operatora == "%")
            {
                result = n1 % n2;

                Console.WriteLine($"{n1} {operatora} {n2} = {result}");
            }
        }
    }
}
