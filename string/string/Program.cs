using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Ivan";
            string lastname = "Ivanov";
            string fullname = (firstname + "" + lastname);
            Console.WriteLine("Hello, my name is " + firstname + "!");
            Console.WriteLine("My lastname is " + lastname +".");
        }
    }
}
