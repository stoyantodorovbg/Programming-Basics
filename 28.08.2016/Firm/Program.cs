using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double needHours = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double extraordinarilyWorkingClerks = double.Parse(Console.ReadLine());

            days *= 0.9d;
            double workHours = days * 8d;
            double extraordinaryHours = (extraordinarilyWorkingClerks * 2d) * days;
            workHours = extraordinaryHours + workHours;
            workHours = Math.Floor(workHours);
            double difference = Math.Abs(workHours - needHours);

            if (workHours >= needHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(difference)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(difference)} hours needed.");
            }
        }
    }
}
