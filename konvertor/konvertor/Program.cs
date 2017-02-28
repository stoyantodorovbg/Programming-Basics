using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var leva = int.Parse(Console.ReadLine());
            var evro = leva / 1.95538;
            Console.WriteLine(evro);
        }
    }
}
