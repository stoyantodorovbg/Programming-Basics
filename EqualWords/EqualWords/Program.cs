using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            var LowerCaseFirstWord = firstWord.ToLower();
            var LowerCaseSecondWord = secondWord.ToLower();
            if (LowerCaseFirstWord == LowerCaseSecondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
