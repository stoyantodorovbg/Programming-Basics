using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var yoans = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
           
                var bitcoinsInLeva = bitcoins * 1168d;
                var dollarInLeva = 1.76d;
                var yoanInLeva = dollarInLeva * 0.15d;
                var yoansInLeva = yoans * yoanInLeva;
                var yoansInEuro = yoansInLeva / 1.95d;
                var bitcoinsInEuro = bitcoinsInLeva / 1.95d;
                var sum = yoansInEuro + bitcoinsInEuro; 
                var result = sum - (sum * (comission / 100d));
                Console.WriteLine(result);
        }
    }
}
