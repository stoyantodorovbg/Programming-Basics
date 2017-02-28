using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOftwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
     
            

            for (var a = 0; a < n + 1; a ++)
            {
                Console.WriteLine(num);
                num = num * 2;
                
            }
        }
    }
}
