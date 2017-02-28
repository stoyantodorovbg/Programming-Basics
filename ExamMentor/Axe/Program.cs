using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i ++)
            {
                var lefttDashes = new string ('-', 3 * n);
                var middleDashes = new string ('-', i);
                var rightDashes = new string('-', 2 * n - 2 - i);
                var star = '*';
                Console.Write("{0}{1}{2}{3}{4}", lefttDashes, star,
                    middleDashes, star, rightDashes);
                Console.WriteLine();

            }

            string axehendle = ${ "new string('*', 3 * n)}*{new string'-', n - 1} + 
$"{new string('-""
            for ()
        }
    }
}
