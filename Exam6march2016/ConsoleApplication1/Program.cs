using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfComing = int.Parse(Console.ReadLine());
            int minuteOfComing = int.Parse(Console.ReadLine();

            hourOfExam *= 60;
            hourOfComing *= 60;

            double exam = hourOfExam + minuteOfExam;
            double coming = hourOfComing + minuteOfComing;


            if (exam > coming)
            {
                Console.WriteLine("Late");
            }
            else if (exam - coming <= 30d && exam - coming > 0D)
            {
                Console.WriteLine("On time");
            }
            else if (exam - coming >= 30d)
            {
                Console.WriteLine("Early");
            }

            if (exam - coming < 60 && exam - coming > 0)
            {
                Console.WriteLine("{0}minute before the start", exam - coming);
            }
            else if (exam - coming >= 60)
            {
                Console.WriteLine("{0}:{1} minutes before the start", Math.Floor((exam - coming) / 60),
                    (exam - coming) - ((Math.Floor((exam - coming) / 60)) * 60));
            }
            else if (coming - exam < 60 && coming - exam > 0)
            {
                Console.WriteLine("{} minutes after the start", coming - exam);
            }
            else if (coming - exam >= 60)
            {
                Console.WriteLine("{0}:{1} minutes after the start", Math.Floor((coming - exam) / 60),
                    (coming - exam) - ((Math.Floor((coming - exam) / 60)) * 60));
            }
        }
    }
}
