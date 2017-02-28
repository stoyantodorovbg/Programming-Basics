using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetno_necetno
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =7;
            int ostatak = number % 2;
            bool chetno = (ostatak != 0);
            Console.WriteLine(chetno?"the number is odd":"the number is even");

             
            
        }
    }
}
