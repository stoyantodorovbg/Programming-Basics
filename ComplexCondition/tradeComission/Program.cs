using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var turnover = decimal.Parse(Console.ReadLine());
            var comission = -1m;
            if (town == "sofia")
            {
                if (turnover <= 500 && turnover > 0)
                {
                    comission = 0.05m;
                }
                else if (turnover > 500 && turnover <= 1000)
                {
                    comission = 0.07m;
                }
                else if (turnover > 1000 && turnover <= 10000)
                {
                    comission = 0.08m;
                }
                else if (turnover > 10000)
                {
                    comission = 0.12m;
                }
            }
            else if (town == "varna")
            {
                if (turnover <= 500 && turnover > 0)
                {
                    comission = 0.045m;
                }
                else if (turnover > 500 && turnover <= 1000)
                {
                    comission = 0.075m;
                }
                else if (turnover > 1000 && turnover <= 10000)
                {
                    comission = 0.10m;
                }
                else if (turnover > 10000)
                {
                    comission = 0.13m;
                }
            }
            else if (town == "plovdiv")
            {
                if (turnover <= 500 && turnover > 0)
                {
                    comission = 0.055m;
                }
                else if (turnover > 500 && turnover <= 1000)
                {
                    comission = 0.08m;
                }
                else if (turnover > 1000 && turnover <= 10000)
                {
                    comission = 0.12m;
                }
                else if (turnover > 10000)
                {
                    comission = 0.145m;
                }
            }
            if (comission <= 0 ||(town != "sofia" && town != "plovdiv" && town != "varna"))
            {
                Console.WriteLine("error");
            }
            else
            {
                comission *= turnover;
                Console.WriteLine("{0:f2}", comission);
            }
        }
    }
}
