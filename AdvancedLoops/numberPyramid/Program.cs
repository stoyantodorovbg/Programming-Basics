﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var number = 1;

            for (var row = 0; row < n; row ++)
            {
                var col = 0;
                for (col = 0; col <= row; col++)
                {
                    Console.Write(number);
                    Console.Write(' ');

                    number++;

                    if (number > n)
                    {
                        break;
                    }

                }
                if (row < col)
                {
                    Console.WriteLine();
                }

                if (number > n)
                {
                    break;
                }

            }
        }
    }
}
