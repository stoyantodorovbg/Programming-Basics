using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizwedeniqOtNdoM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n(n<m)= ");
                int n = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());
            long product = 1;
            do
            {
                product *= n;
                n++;
            } while (n <= m);
            Console.WriteLine("product[n..m] is " + product);
        }
    }
}
