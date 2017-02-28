using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            if (number == 10)
            {
                Console.WriteLine("ten");
            }
            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number / 10 == 1 && number % 10 == 1)
            {
                Console.WriteLine("eleven");
            }
            else if (number / 10 == 1 && number % 10 == 2)
            {
                Console.WriteLine("twelve");
            }
            else if (number / 10 == 1 && number % 10 == 3)
            {
                Console.WriteLine("thirteen");
            }
            else if (number / 10 == 1 && number % 10 == 4)
            {
                Console.WriteLine("fourteen");
            }
            else if (number / 10 == 1 && number % 10 == 5)
            {
                Console.WriteLine("fifteen");
            }
            else if (number / 10 == 1 && number % 10 == 6)
            {
                Console.WriteLine("sixteen");
            }
            else if (number / 10 == 1 && number % 10 == 7)
            {
                Console.WriteLine("seventeen");
            }
            else if (number / 10 == 1 && number % 10 == 8)
            {
                Console.WriteLine("eighteen");
            }
            else if (number / 10 == 1 && number % 10 == 9)
            {
                Console.WriteLine("nineteen");
            }
                if (number / 2 == 10)
                {
                    Console.Write("twenty");
                }
                else if (number / 3 == 10)
                {
                    Console.Write("thirty");
                }
                else if (number / 4 == 10)
                {
                    Console.Write("fourty");
                }
                else if (number / 5 == 10)
                {
                    Console.Write("fifty");
                }
                else if (number / 6 == 10)
                {
                    Console.Write("sixty");
                }
                else if (number / 7 == 10)
                {
                    Console.Write("seventy");
                }
                else if (number / 8 == 10)
                {
                    Console.Write("eighty");
                }
                else if (number / 9 == 10)
                {
                    Console.Write("ninety");
                }
                if (number % 10 != 0 && number != 100)
                {
                    Console.Write(" ");
                if (number == 1 || number % 10 == 1)
                {
                    Console.WriteLine("one");
                }
                else if (number == 2 || number % 10 == 2)
                {
                    Console.WriteLine("two");
                }
                else if (number == 3 || number % 10 == 3)
                {
                    Console.WriteLine("three");
                }
                else if (number == 4 || number % 10 == 4)
                {
                    Console.WriteLine("four");
                }
                else if (number == 5 || number % 10 == 5)
                {
                    Console.WriteLine("five");
                }
                else if (number == 6 || number % 10 == 6)
                {
                    Console.WriteLine("six");
                }
                else if (number == 7 || number % 10 == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (number == 8 || number % 10 == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (number == 9 || number % 10 == 9)
                {
                    Console.WriteLine("nine");
                }  
            }
        }
    }
}
