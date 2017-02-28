using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostoChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 
                Convert.ToInt32(Console.ReadLine());
            bool deleneNaSebeSi = number % number == 0;
            bool deleneNaEdno = number % 1 == 0;
            if (number > 0 && number < 100)
                Console.WriteLine(deleneNaSebeSi && deleneNaEdno ? number + " e prosto chislo " : number + " ne e prosto chislo");
            else
                Console.WriteLine("Please insert number smaller by 100 and bigger  by 0!");
                


        }
    }
}
