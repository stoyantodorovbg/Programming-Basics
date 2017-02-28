using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a =1, b = 1; a<=128; a=a*2, b+=a)
            {
                Console.WriteLine("a ={0}, b ={1}", a, b);
            }
        }
    }
}
