using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radianiToGradusi
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            var degree = radians * (180 / Math.PI);
            Math.Round(degree);
            Console.WriteLine(degree);
        }
    }
}
