using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime
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
                if (hourOfExam >= hourOfArriving && minuteOfExam >= minuteOfArriving)
                {
                    Console.WriteLine("Early");
                    differenceMinutes = minuteOfExam - minuteOfArriving;
                    differenceHours = hourOfExam - hourOfArriving;
                    if (hourOfExam == hourOfArriving && minuteOfExam > minuteOfArriving && 
                        differenceMinutes <= 9)
                    {
                        Console.WriteLine("0{0} minutes before the start", differenceMinutes);
                    }
                    else if (hourOfExam == hourOfArriving && minuteOfExam > minuteOfArriving && 
                        differenceMinutes > 9)
                    {
                        Console.WriteLine("{0} minutes before the start", differenceMinutes);
                    }
                    if (hourOfExam > hourOfArriving && minuteOfExam > minuteOfArriving &&
                        differenceMinutes <= 9)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", differenceHours,
                            differenceMinutes);
                    }
                    else if (hourOfExam > hourOfArriving && minuteOfExam > minuteOfArriving &&
                        differenceMinutes >= 9)
                    {
                        Console.WriteLine("{0}:{1} hours before the start", differenceHours,
                            differenceMinutes);
                    }
                }
                else if (hourOfExam > hourOfArriving && minuteOfExam >= minuteOfArriving)
                {
                    Console.WriteLine("Early");
                    differenceMinutes = minuteOfExam - minuteOfArriving;
                    differenceHours = hourOfExam - hourOfArriving;
                    if (hourOfExam == hourOfArriving && differenceMinutes <= 9)
                    {
                        Console.WriteLine("0{0} minutes before the start", differenceMinutes);
                    }
                    else if (hourOfExam == hourOfArriving && differenceMinutes > 9)
                    {
                        Console.WriteLine("{0} minutes before the start", differenceMinutes);
                    }
                    if (hourOfExam > hourOfArriving && differenceMinutes <= 9)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", differenceHours,
                            differenceMinutes);
                    }
                    else if (hourOfExam > hourOfArriving && differenceMinutes >= 9)
                    {
                        Console.WriteLine("{0}:{1} hours before the start", differenceHours,
                            differenceMinutes);
                    }
                }
                else if (hourOfExam <= hourOfArriving && minuteOfExam < minuteOfArriving)
                {
                    Console.WriteLine("Late");
                    differenceHours = hourOfArriving - hourOfExam;
                    differenceMinutes = minuteOfArriving - minuteOfExam;
                    if (hourOfExam == hourOfArriving && differenceMinutes <= 9)
                    {
                        Console.WriteLine("0{0} minutes after the start", differenceMinutes);
                    }
                    else if (hourOfExam == hourOfArriving && differenceMinutes > 9)
                    {
                        Console.WriteLine("{0} minutes after the start", differenceMinutes);
                    }
                    if  (hourOfArriving < hourOfExam && differenceMinutes <= 9)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", differenceHours,
                            differenceMinutes);
                    }
                    else if (hourOfArriving < hourOfExam && differenceMinutes > 9)
                    {
                        Console.WriteLine("{0}:{1} hours after the start", differenceHours,
                            differenceMinutes);
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
