using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentOrNotExcellent
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = double.Parse(Console.ReadLine());
            if (score >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not Excellent.");
            }
        }
    }
}
