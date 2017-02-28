using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =  {1,3,5,7,9,2,4,6,8,11};
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }
            String[] towns = { "Sofia", "Burgas", "Velingrad", "Plovdiv", "Samokov", "Varna" };
            foreach (String town in towns)
            {
                Console.Write(" " + town);
            }
        }
    }
}
