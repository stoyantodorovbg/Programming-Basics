using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;

                while (number % 10 > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                bool isSpecial = false;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;   
                }

                Console.WriteLine($"{number} -> {isSpecial}");
            }
        }
    }
}
