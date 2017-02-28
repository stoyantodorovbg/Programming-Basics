using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int answerA = 0;
            int answerB = 0;
            int answerC = 0;
            int answerD = 0;

            string a = null;


            for (int i = 0; i < n; i ++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i == n - 1)
                {
                    if (number % 4 == 0)
                    {
                        a += "a";
                        answerA++;
                    }
                    else if (number % 4 == 1)
                    {
                        a += "b";
                        answerB++;
                    }
                    else if (number % 4 == 2)
                    {
                        a += "c";
                        answerC++;
                    }
                    else if (number % 4 == 3)
                    {
                        a += "d";
                        answerD++;
                    }

                    break;
                }
                if (number % 4 == 0)
                {
                    a += "a ";
                    answerA++;
                }
                else if (number % 4 == 1)
                {
                    a += "b ";
                    answerB++;
                }
                else if (number % 4 == 2)
                {
                    a += "c ";
                    answerC++;
                }
                else if (number % 4 == 3)
                {
                    a += "d ";
                    answerD++;
                }
            }

            Console.WriteLine(a);

            Console.WriteLine($"Answer A: {answerA}");
            Console.WriteLine($"Answer B: {answerB}");
            Console.WriteLine($"Answer C: {answerC}");
            Console.WriteLine($"Answer D: {answerD}");
        }
    }
}
