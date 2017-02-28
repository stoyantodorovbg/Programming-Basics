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
            int period = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreatedPatients = 0;
            int untreatedPatientsForDay = 0;
            int doctors = 7;

            for (int day = 1; day <= period; day++)
            {
                int patientsForDay = int.Parse(Console.ReadLine());

                if (day % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if (patientsForDay > doctors)
                {
                    untreatedPatientsForDay += patientsForDay - doctors;
                    untreatedPatients += untreatedPatientsForDay;
                }

                treatedPatients += Math.Abs(patientsForDay - untreatedPatientsForDay);

                untreatedPatientsForDay = 0;

                
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
