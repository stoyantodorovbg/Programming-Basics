﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumirane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert value for n: ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            Console.Write("The sum is: ");
            while(num<n)
            {
                num++;
                sum += num;
                Console.Write("+" + num);
                Console.WriteLine("="+sum);
            }



        }
    }
}
