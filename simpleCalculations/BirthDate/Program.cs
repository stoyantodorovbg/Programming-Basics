using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDate
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy", null);
           DateTime newDate = date.AddDays(999);
           Console.WriteLine(newDate.ToString("dd-MM-yyyy"));
        }
    }
}
