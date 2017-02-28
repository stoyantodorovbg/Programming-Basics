using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLatters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sum = 0;
            for (var a = 0; a < text.Length; a ++)
            {
                if (text[a] == 'a')
                {
                    sum += 1;
                }
                else if (text[a] == 'e')
                {
                    sum += 2;
                }
                else if (text[a] == 'i')
                {
                    sum += 3;
                }
                else if
            }
        }
    }
}
