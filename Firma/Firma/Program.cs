using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = double.Parse(Console.ReadLine());
            var days = double.Parse(Console . ReadLine());
            var extraWorkers = double.Parse(Console.ReadLine());
            var WorkHours = (days * 0.9d) * 8d;
            var extraHours = (extraWorkers * 2d) * days;
            var allHours = Math.Floor(WorkHours + extraHours);
            var result = neededHours - allHours;
            if (neededHours > allHours)
            {   
                Console.WriteLine("Not enough time!{0} hours needed.", result);
            }
            else
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Abs(result));
            }

        }
    }
}
