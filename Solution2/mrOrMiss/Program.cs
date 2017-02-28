using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mrOrMiss
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gander = Console.ReadLine();
            if (gander == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            if (gander == "f")
                {
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else
                    {
                        Console.WriteLine("Ms.");
                    }
                }
            }
        }
    }

