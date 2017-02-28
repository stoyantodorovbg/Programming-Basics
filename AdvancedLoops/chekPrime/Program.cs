using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 1;
            var prime = true;
            if (n > 1)
            {

                for (var a = 2; a < n; a++)
                {
                    result = n % a;

                    if (result == 0)
                    {
                        prime = false;
                        Console.WriteLine("Not Prime");
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("Prime");
                }
            }
            else 
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
