using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChislaKoitoNeSeDelqtNaTriISedem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert n: ");
                int n = int.Parse(Console.ReadLine());
            for (int a = 1; a <= n; a++)
            {
                if (a % (3*7) == 0 )
                {
                    continue;
                }
                
                Console.Write(" " + a); 
            }
        }
    }
}
