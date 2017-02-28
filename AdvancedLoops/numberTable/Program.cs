using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            

            for (var row = 0; row < n; row++)
            {
                var number1 = row + 1;
                var number2 = n - 1;

                for (var col = 0; col < n - row; col ++)
                {
                    Console.Write(number1);
                    Console.Write(' ');
                    number1 ++;

                }

                if (row > 0)
                {
                    for (var col = 0; col < row; col++)
                    {
                        Console.Write(number2);
                        Console.Write(' ');
                        number2 --;
                    }
                }


                Console.WriteLine();
            }
        }
    }
}
