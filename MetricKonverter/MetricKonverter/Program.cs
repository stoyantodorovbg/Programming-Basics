using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricKonverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var enter = Console.ReadLine();
            var exit = Console.ReadLine();
            if (enter == "mm")
            {
                lenght /= 1000;
            }
            else if (enter == "cm")
            {
                lenght /= 100;
            }
            else if (enter == "mi")
            {
                lenght /= 0.000621371192;
            }
            else if (enter == "in")
            {
                lenght /= 39.3700787;
            }
            else if (enter == "km")
            {
                lenght /= 0.001;
            }
            else if (enter == "ft")
            {
                lenght /= 3.2808399;
            }
            else if (enter == "yd")
            {
                lenght /= 1.0936133;
            }   
            else if (enter == "m")
            {
                lenght /= 1;
            }
            var result = lenght;
            var measure = "null";
            if (exit == "mm")
            {
                result *= 1000;
                measure = "mm";
            }
            else if (exit == "cm")
            {
                result *= 100;
                measure = "cm";
            }
            else if (exit == "mi")
            {
                result *= 0.000621371192;
                measure = "mi";
            }
            else if (exit == "in")
            {
                result *= 39.3700787;
                measure = "in";  
            }
            else if (exit == "km")
            {
                result *= 0.001;
                measure = "km";
            }
            else if (exit == "ft")
            {
                result *= 3.2808399;
                measure = "ft";
            }
            else if (exit == "yd")
            {
                result *= 1.0936133;
                measure = "yd";
            }
            else if (exit == "m")
            {
                result *= 1;
                measure = "m";
            }
            Console.WriteLine(result + " " + measure);
        }
    }
}
