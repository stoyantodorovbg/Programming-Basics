using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delene_bez_ostatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 35;
            int ostatak = ((number % 5) + (number % 7));
            bool proverka = ostatak == 0;
            Console.WriteLine(proverka ? "Chisloto " + number + " se deli na 5 i 7 bez ostatak":" Chisloto " + number + " se deli na 5 i 7 sys ostatak") ;
            number++;
            ostatak = ((number % 5) + (number % 7));
            proverka = ostatak == 0;
            Console.WriteLine(proverka ? " Chisloto" + number + " se deli na 5 i 7 bez ostatak" : " Chisloto " + number + " se deli na 5 i 7 sys ostatak");
        }
    }
}
