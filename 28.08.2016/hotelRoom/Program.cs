using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double studio = 0;
            double apartament = 0;

            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                apartament = 65 * nights;

                if (nights > 14)
                {
                    studio -= studio * 0.3;
                }

                else if (nights > 7)
                {
                    studio -= studio * 0.05;
                }
            }

            else if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                apartament = 68.70 * nights;

                if (nights > 14)
                {
                    studio -= studio * 0.2;
                }
            }

            else if (month == "July" || month == "August")
            {
                studio = 76 * nights;
                apartament = 77 * nights;
            }

            if (nights > 14)
            {
                apartament -= apartament * 0.1;
            }

            Console.WriteLine($"Apartment: {apartament:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
