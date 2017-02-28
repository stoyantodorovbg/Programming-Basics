using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proverka_na_tretata_cifra
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;
            var a = 0;
            for (a = 0; a < n; a++)
            {
                var number = int.Parse(Console.ReadLine());
             if (a % 2 == 0)
                {
                    evenSum += number;
                } 
             else
                {
                    oddSum += number;
                }  
             
            }
            var result = evenSum - oddSum;
            if (result == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(result));
            }

        }
    }
}
