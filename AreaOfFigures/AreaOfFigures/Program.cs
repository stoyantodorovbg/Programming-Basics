using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figura = Console.ReadLine();
            if (figura == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var squareArea = side * side;
                Console.WriteLine(Math.Round(squareArea, 3));
            }
            else if (figura == "rectangle")
            {
                var sideOne = double.Parse(Console.ReadLine());
                var sideTwo = double.Parse(Console.ReadLine());
                var rectangleArea = sideOne * sideTwo;
                Console.WriteLine(Math.Round(rectangleArea, 3));
            }
            else if (figura == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                var circleArea = Math.PI * radius * radius;
                Console.WriteLine(Math.Round(circleArea, 3));
            }
            else if (figura == "triangle")
            {
                var sideOfTriangle = double.Parse(Console.ReadLine());
                var hightOfTriangle = double.Parse(Console.ReadLine());
                var triangleArea = (sideOfTriangle * hightOfTriangle) / 2;
                Console.WriteLine(Math.Round(triangleArea, 3));
            }
        }
    }
}
