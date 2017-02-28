using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOffs = int.Parse(Console.ReadLine());
            if (dayOffs >= 0 && dayOffs <= 365)
            {
                var playDayOffs = dayOffs * 127;
                var workDays = 365 - dayOffs;
                var playWorkDays = workDays * 63;
                var playDays = playDayOffs + playWorkDays;
                if ( playDays > 30000)
                {
                    var superflousPlay = playDays - 30000;
                    var superflousHours = superflousPlay / 60;
                    var superflousMinutes = superflousPlay % 60;
                    Console.WriteLine("Tom will run allay");
                    Console.WriteLine("{0} hours and {1} minutes more for play"
                        , superflousHours, superflousMinutes);
                }
                else
                {
                    Console.WriteLine("Tom sleeps well");
                    var play = 30000 - playDays;
                    var hours = play / 60;
                    var minutes = play % 60;
                    Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
                }
            }
        }
    }
}
