using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < 'a' + n; first++)
            {
                for (char second = 'a'; second < 'a' + n; second++)
                {
                    for (char third = 'a'; third < 'a' + n; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }

            }
        }
    }
}
