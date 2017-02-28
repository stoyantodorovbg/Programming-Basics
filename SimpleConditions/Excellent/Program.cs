using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = double.Parse(Console.ReadLine());
            if (score >= 5.50 && score <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
