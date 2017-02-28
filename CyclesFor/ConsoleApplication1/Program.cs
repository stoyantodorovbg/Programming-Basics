using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var b = 0;
            var max = int.MinValue;
            for (var a = 0; a < n; a ++)
            {
                var number = int.Parse(Console.ReadLine());
                b = number;
                if (b > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
