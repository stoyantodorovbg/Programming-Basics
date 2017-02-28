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
            int neededHours = int.Parse(Console.ReadLine());
            int totalWorkingDays = int.Parse(Console.ReadLine());
            int numberOfOverTimeWorkers = int.Parse(Console.ReadLine());

            double actualWorkingDays = totalWorkingDays * 0.9;
            var totalWorkingHours = actualWorkingDays * 8;
            var overTimeHours = totalWorkingDays * numberOfOverTimeWorkers * 2;
            totalWorkingHours += overTimeHours;
            var difference =Math.Abs(totalWorkingHours - neededHours);
            totalWorkingHours = Math.Floor(totalWorkingHours);

            if(neededHours <= totalWorkingHours)
            {
                Console.WriteLine("YES! {0} hours left", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("Not enough time! {0} hours needed", Math.Floor(difference));
            }
        }
    }
}
