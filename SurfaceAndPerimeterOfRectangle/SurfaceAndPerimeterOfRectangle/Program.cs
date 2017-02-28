using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceAndPerimeterOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter the value of the lenght of the rectangle");
            int a =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of the hight of the rectangle");
            int h =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The peremeter of the rectangle is " + ((a * 2) + (h * 2)) + ". The Surface of the rectangle is " + (a * h) + ".");
        }
    }
}
