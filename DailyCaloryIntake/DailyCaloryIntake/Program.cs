using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFootballStatition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int a = i;
                int fourth = a % 10;
                a /= 10;
                int third = a % 10;
                a /= 10;
                int second = a % 10;
                int first = a / 10;
                if (n % first == 0 && n % second == 0 && n % third == 0 && i % fourth == 0)
            {
                    Console.Write($"{i} ");
            } 
            }

        }
    }
}
