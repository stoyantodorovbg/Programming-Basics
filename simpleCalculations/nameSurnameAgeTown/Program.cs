using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameSurnameAgeTown
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var surname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("Hello {0}  {1} you are {2} years old and your town is {3}.", name, surname, age, town);
        }
    }
}
