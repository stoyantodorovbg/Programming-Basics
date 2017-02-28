using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocemonsFirstGamer = int.Parse(Console.ReadLine());
            int pocemonsSecondGamer = int.Parse(Console.ReadLine());
            int battlesMaxCount = int.Parse(Console.ReadLine());
            int maches = 0;


                for (int i = 1; i <= pocemonsFirstGamer; i++)
                {
                    for (int i1 = 1; i1 <= pocemonsSecondGamer; i1++)
                    {
                        Console.Write($"({i} <-> {i1}) ");
                        maches = i * i1;

                        if (maches >= battlesMaxCount)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

