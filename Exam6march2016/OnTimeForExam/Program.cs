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
            int minuteOfComing = int.Parse(Console.ReadLine());

            hourOfExam *= 60;
            hourOfComing *= 60;

            double exam = hourOfExam + minuteOfExam;
            double coming = hourOfComing + minuteOfComing;


            if (exam < coming)
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
                var b = exam - coming;
                Console.WriteLine("{0} minutes before the start", b);
            }
            else if (exam - coming >= 60)
            {
                var a = Math.Floor((exam - coming) / 60);
                var b = (exam - coming) - ((Math.Floor((exam - coming) / 60)) * 60);
                if (b <= 9)
                {
                    Console.WriteLine("{0}:0{1} hours before the start", a, b);
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours before the start", a, b);
                }
            }
            else if (coming - exam < 60 && coming - exam > 0)
            {
                var a = coming - exam;
                Console.WriteLine("{0} minutes after the start", a);
            }
            else if (coming - exam >= 60)
            {
                var a = Math.Floor((coming - exam) / 60);
                var b = (coming - exam) - ((Math.Floor((coming - exam) / 60)) * 60);
                if (b <= 9)
                {
                    Console.WriteLine("{0}:0{1} hours after the start", a, b);
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours after the start", a, b);
                }
            }
            else if (coming == exam)
            {
                Console.WriteLine("On time");
            }
        }
    }
}
