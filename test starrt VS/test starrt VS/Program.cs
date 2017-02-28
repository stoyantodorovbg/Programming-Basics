using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_starrt_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");
            for (int i = 200; i <=2000; i +=2000)
            {
                Console.Beep(i, 2000);
            }
        }
    }
}
