using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablePrice = decimal.Parse(Console.ReadLine());
            var fruitPrice = decimal.Parse(Console.ReadLine());
            var vegetableAmount = int.Parse(Console.ReadLine());
            var fruitAmount = int.Parse(Console.ReadLine());
            if (vegetablePrice <= 1000 && fruitPrice <=1000 && vegetableAmount <=1000 && fruitAmount <= 1000 && vegetablePrice >= 0 && fruitPrice >= 0 && vegetableAmount >= 0 && fruitAmount >=0)
            {
                decimal vegetableIncomeLv = vegetablePrice * vegetableAmount;
                decimal fruitIncomeLv = fruitPrice * fruitAmount;
                decimal allIncomeLv = vegetableIncomeLv + fruitIncomeLv;
                decimal allIncomeEuro = allIncomeLv / 1.94M;
                Console.WriteLine(allIncomeEuro); 


            }


        }
    }
}
