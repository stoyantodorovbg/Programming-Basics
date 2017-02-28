using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double iuans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double euro = 0;

            euro += (bitcoins * 1168d) / 1.95d;
            euro += ((iuans * 0.15d) * 1.76d) / 1.95d;
            euro = euro - (euro * (comission / 100d));

            Console.WriteLine(euro);

         
        }
    }
}
