using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var side = int.Parse(Console.ReadLine());
            var area = side * side;
            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
