using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            var meters = 0d;
            if (input == "mm")
            {
                meters = lenght /= 1000;
            }
            else if (input == "cm")
            {
                meters = lenght /= 100;
            }
            else if (input == "mi")
            {
                meters = lenght /= 0.000621371192;
            }
            else if (input == "in")
            {
                meters = lenght /= 39.3700787;
            }
            else if (input == "km")
            {
                meters = lenght /= 0.001;
            }
            else if (input == "ft")
            {
                meters = lenght /= 3.2808399;
            }
            else if (input == "yd")
            {
                meters = lenght /= 1.0936133;
            }
            else if (input == "m")
            {
                meters /= 1;
            }
            var measure = "m";
            if (output == "mm")
            {
                meters *= 1000;
                measure = "mm";
            }
            else if (output == "cm")
            {
                meters *= 100;
                measure = "cm";
            }
            else if (output == "mi")
            {
                meters *= 0.000621371192;
                measure = "mi";
            }
            else if (output == "in")
            {
                meters *= 393700787;
                measure = "in";
            }
            else if (output == "km")
            {
                meters *= 0.001;
                measure = "km";
            }
            else if (output == "ft")
            {
                meters *= 3.2808399;
                measure = "ft";
            }
            else if (output == "yd")
            {
                meters *= 1.0936133;
                measure = "yd";
            }
            else if (output == "m")
            {
                meters *= 1;
                measure = "m";
            }
            Console.WriteLine(meters + " " + measure);
        }
    }
}
