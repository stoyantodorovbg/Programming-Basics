using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            var price = 0m;

            switch (type)
            {
                case "premiere":
                    price = 12.00m;
                    break;
                case "normal":
                    price = 7.50m;
                    break;
                case "discount":
                    price = 5.00m;
                    break;
            }
            var places = row * col;
            var incomes = places * price;
            Console.WriteLine("{0:f2} leva", incomes);
        }
    }
}
