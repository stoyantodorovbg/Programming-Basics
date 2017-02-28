using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = decimal.Parse(Console.ReadLine());
            var firstCurrency = Console.ReadLine();
            var secondCurrency = Console.ReadLine();
            if (firstCurrency == "USD")
            {
                sum *= 1.79549m;
            }
            if (firstCurrency == "EUR")
            {
                sum *= 1.95583m;
            }
            if (firstCurrency == "GBP")
            {
                sum *= 2.53405m;
            }
            if (firstCurrency == "BGN")
            {
                sum *= 1m;
            }
            if (secondCurrency == "USD")
            {
                Console.WriteLine(Math.Round(sum / 1.79549m, 2) + " USD");
            }
            if (secondCurrency == "EUR")
            {
                Console.WriteLine(Math.Round(sum / 1.95583m, 2) + " EUR");
            }
            if (secondCurrency == "GBP")
            {
                Console.WriteLine(Math.Round(sum / 2.53405m, 2) + " GBP");
            }
            if (secondCurrency == "BGN")
                Console.WriteLine(Math.Round(sum / 1m, 2) + " BGN");       
        }
    }
}
