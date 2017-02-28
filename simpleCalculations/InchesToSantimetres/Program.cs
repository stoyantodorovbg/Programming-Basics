using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToSantimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inces = ");
            var inches = double.Parse(Console.ReadLine());
            var santimeteres = inches * 2.54;
            Console.WriteLine("The demention in santimetres is: ");
            Console.WriteLine(santimeteres);
        }
    }
}
