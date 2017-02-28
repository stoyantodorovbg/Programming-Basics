using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daliTockaEVytreVokryjnost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of dot O:");
            Console.WriteLine("x = ");
                int x =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = ");
            int y =
            Convert.ToInt32(Console.ReadLine());
            bool vytreXY = (x < 5)&&(y<5);
            Console.WriteLine(vytreXY?"The dot O is in the circumference":"The dot O is out of the circumference");
            bool outOfTheRectangle = (((x < -3) || (x > 3)) || ((y < 0) || (y > 5)));
            Console.WriteLine(outOfTheRectangle ? "The dot O is out of the rectangle." : "The dot O is in the rectangle");
        }
    }
}
