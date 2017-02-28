using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime1
{
    class Program
    {
        static void Main(string[] args)
        {
                    var hourOfExam = int.Parse(Console.ReadLine());
            var minuteOfExam = int.Parse(Console.ReadLine());
            var hourOfArriving = int.Parse(Console.ReadLine());
            var minuteOfArriving = int.Parse(Console.ReadLine());
            var differenceHours = 0;
            var differenceMinutes = 0;
            if (hourOfExam >= 0 && hourOfExam <= 23 && minuteOfExam >= 0 && minuteOfExam <= 59 &&
                hourOfArriving >= 0 && hourOfArriving <= 59 && minuteOfArriving >= 0 &&
                minuteOfArriving <= 59)
            {
                if (hourOfExam < hourOfArriving && minuteOfExam < minuteOfArriving ||
                    (hourOfExam == hourOfArriving && minuteOfExam < minuteOfArriving) ||
                    (hourOfExam < hourOfArriving && minuteOfExam == minuteOfArriving) ||
                    (hourOfExam < hourOfArriving && minuteOfExam > minuteOfArriving))
                {
                    Console.WriteLine("Late");
                    differenceHours = hourOfArriving - hourOfExam;
                    if (minuteOfArriving > minuteOfExam)
                    {
                        differenceMinutes = minuteOfArriving - minuteOfExam;
                    }
                    else if (minuteOfArriving < minuteOfExam)
                    {
                        differenceMinutes = minuteOfExam + minuteOfArriving;
                        differenceHours--;
                    }
                    if (differenceMinutes <= 9 && differenceHours > 0)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", Math.Abs(differenceHours),
                                Math.Abs(differenceMinutes));
                    }
                    else if (differenceMinutes > 9 && differenceHours > 0)
                    {
                        Console.WriteLine("{0}:{1} hours after the start", Math.Abs(differenceHours),
                                Math.Abs(differenceMinutes));
                    }
                    else if (differenceMinutes <= 9 && differenceHours == 0)
                    {
                        Console.WriteLine("{0} minutes after the start",
                                Math.Abs(differenceMinutes));
                    }
                    else if (differenceMinutes > 9 && differenceHours == 0)
                    {
                        Console.WriteLine("{0} minutes after the start",
                                Math.Abs(differenceMinutes));
                    }
                }
                else if ((hourOfExam > hourOfArriving && minuteOfExam > minuteOfArriving) ||
                    (hourOfExam == hourOfArriving && minuteOfExam > minuteOfArriving) ||
                    (hourOfExam > hourOfArriving && minuteOfExam == minuteOfArriving) ||
                    (hourOfExam > hourOfArriving && minuteOfExam < minuteOfArriving))
                {
                    differenceHours = hourOfExam - hourOfArriving;
                    if (minuteOfArriving < minuteOfExam)
                    {
                        differenceMinutes = minuteOfExam - minuteOfArriving;
                    }
                    else if (minuteOfArriving > minuteOfExam)
                    {
                        differenceMinutes = minuteOfExam + (60 - minuteOfArriving);
                        differenceHours--;
                    }
                    if (differenceMinutes <= 30 && differenceHours == 0)
                    {
                        Console.WriteLine("On time");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                    }
                    if (differenceMinutes <= 9 && differenceHours > 0)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", Math.Abs(differenceHours),
                                Math.Abs(differenceMinutes));
                    }
                    else if (differenceMinutes > 9 && differenceHours > 0)
                    {
                        Console.WriteLine("{0}:{1} hours before the start", Math.Abs(differenceHours),
                                Math.Abs(differenceMinutes));
                    }
                    else if (differenceMinutes <= 9 && differenceHours == 0)
                    {
                        Console.WriteLine("{0} minutes before the start",
                                Math.Abs(differenceMinutes));
                    }
                    else if (differenceMinutes > 9 && differenceHours == 0)
                    {
                        Console.WriteLine("{0} minutes before the start",
                                Math.Abs(differenceMinutes));
                    }
                }
                else if (hourOfExam == hourOfArriving && minuteOfExam == minuteOfArriving)
                {
                    Console.WriteLine("On time");
                }
            }
        }
    }
}
