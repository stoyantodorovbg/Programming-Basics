using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaNecetniChislaKoitoNeSeDelyatNa_Sedem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert the number!");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i<=a; i+=2)
            {
                if(i%7==0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
