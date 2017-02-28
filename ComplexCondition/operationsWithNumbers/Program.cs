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
            var numberOne = double.Parse(Console.ReadLine());
            var numberTwo = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            var result = 1d;
            var evenOrOdd = "null";
            if (sign == "*")
            {
                result = numberOne * numberTwo;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numberOne, sign, numberTwo, result, evenOrOdd);
                }
                else if (result % 2 == 1)
                {
                    evenOrOdd = "odd";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numberOne, sign, numberTwo, result, evenOrOdd);
                }
            }
            else if (sign == "+")
            {
                result = numberOne + numberTwo;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numberOne, sign, numberTwo, result, evenOrOdd);
                }
                else if (result % 2 == 1)
                {
                    evenOrOdd = "odd";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numberOne, sign, numberTwo, result, evenOrOdd);
                }
            }
            else if (sign == "-")
            {
                result = numberOne - numberTwo;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numberOne, sign, numberTwo, result, evenOrOdd);
                }
                else if (result % 2 == 1)
                {
                    evenOrOdd = "odd";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numberOne, sign, numberTwo, result, evenOrOdd);
                }
            }
            else if (sign == "/" && numberTwo != 0)
            {
                result = numberOne / numberTwo;
                
                Console.WriteLine("{0} {1} {2} = {3:f2}", numberOne, sign, numberTwo, result);
            }
            else if (sign == "%" && numberTwo != 0)
            {
                result = numberOne % numberTwo;

                Console.WriteLine("{0} {1} {2} = {3}", numberOne, sign, numberTwo, result);
            }
            else if (numberTwo == 0 && (sign == "/" || sign == "%"))
            {
                Console.WriteLine("Cannot divide {0} by zero", numberOne);
            }
        }
    }
}
