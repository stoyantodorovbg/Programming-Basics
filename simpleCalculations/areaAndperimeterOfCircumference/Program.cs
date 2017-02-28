using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaAndperimeterOfCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("The area of the circumference is {0}, the pereimetr is {1}.", area, perimeter);
        }
    }
}
