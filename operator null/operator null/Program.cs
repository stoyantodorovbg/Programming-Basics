using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 5;
            Console.WriteLine(a ??-1);
            string name = null;
            Console.WriteLine(name ?? "no name");
            int b = 5;
            int d = 6;
            Console.WriteLine(b + d / 2);
            Console.WriteLine((b + d) / 2);
            string s = "beer";
            Console.WriteLine(s is string);
            string notNullString = s;
            string nullString = null;
            Console.WriteLine(notNullString ?? "niama bira");
            Console.WriteLine(nullString ?? "ima bira");
        }
    }
}
