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
            var month = Console.ReadLine();
            var passings = decimal.Parse(Console.ReadLine());
            var studio = 0m;
            var apartament = 0m;
            if (month == "May")
            {
                studio = passings * 50m;
                apartament = passings * 65m;
                if (passings > 7 && passings <= 14)
                {
                    studio = studio - (studio * 0.05m);
                }
                else if (passings > 14)
                {
                    studio = studio - (studio * 0.3m);
                }
            }
            else if (month == "June")
            {
                studio = passings * 75.20m;
                apartament = passings * 68.70m;

                if (passings > 14)
                {
                    studio = studio - (studio * 0.2m);
                }
            }
            else if (month == "July")
            {
                studio = passings * 76m;
                apartament = passings * 77m;
            }
            else if (month == "August")
            {
                studio = passings * 76m;
                apartament = passings * 77m;
            }
            else if (month == "September")
            {
                studio = passings * 75.20m;
                apartament = passings * 68.70m;
                if (passings > 14)
                {
                    studio = studio - (studio * 0.2m);
                }
            }
            else if (month == "October")
            {
                studio = passings * 50m;
                apartament = passings * 65m;
                if (passings > 7 && passings <= 14)
                {
                    studio = studio - (studio * 0.05m);
                }
                else if (passings > 14)
                {
                    studio = studio - (studio * 0.3m);
                }
            } 
            if (passings > 14)
            {
                apartament = apartament - (apartament * 0.1m);
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartament);
            Console.WriteLine("Studio: {0:f2} lv.", studio);
        }
    }
}
