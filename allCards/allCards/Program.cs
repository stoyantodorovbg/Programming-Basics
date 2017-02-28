using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allCards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string 2 = 2 + " dvoika";
            int 2 = 2; 
            for (int cards = 2; cards <= 14; cards ++)
                for (int colour = 1; colour <= 4; colour ++)
                {
                    Console.Write(cards + " " + colour);
                }
        }
    }
}
