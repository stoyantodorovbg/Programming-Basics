using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var cureds = 0;
            var uncureds = 0;
            var doctors = 7;


            for (var a = 1; a <= period; a++)
            {
                var patients = int.Parse(Console.ReadLine());
               

                if (a % 3 == 0 && uncureds > cureds)
                {
                    doctors++;
                }

                if (patients > doctors)
                {
                    uncureds += patients - doctors;
                    cureds += doctors;
                }

                if (patients <= doctors)
                {
                    cureds += patients;
                }

            }

            Console.WriteLine("Treated patients: {0}.", cureds);
            Console.WriteLine("Untreated patients: {0}.", uncureds);
        }
    }
}
