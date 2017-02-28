using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelziiToFarenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            var celzii = double.Parse(Console.ReadLine());
            var farenhait = (celzii * 1.8) + 32;
            Console.WriteLine(farenhait);

        }
    }
}
