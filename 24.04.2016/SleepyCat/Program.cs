using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOffs = int.Parse(Console.ReadLine());

            int workDays = 365 - dayOffs;
            int timeForPlay = (dayOffs * 127) + (workDays * 63);
            int hours = Math.Abs((timeForPlay - 30000) / 60);
            int minutes = Math.Abs((timeForPlay - 30000) % 60);

            if (timeForPlay >= 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }


        }
    }
}
