using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VavedeteCislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert four digits as push the kay enter after eachone:");
            int a =
                Convert.ToInt32(Console.ReadLine());
            int b =
                Convert.ToInt32(Console.ReadLine());
            int c =
                Convert.ToInt32(Console.ReadLine());
            int d =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d+" "+c+" "+b+" "+a);
            Console.WriteLine(a+" "+d+" "+c+" "+b);
            Console.WriteLine(a+" "+c+" "+d+" "+b);



        }
    }
}
