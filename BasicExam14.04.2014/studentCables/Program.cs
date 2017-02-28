using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCables
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var allLenght = 0;
            var brak = 0;

            for (var a = 0; a < n; a ++)
            {
                var lenght = int.Parse(Console.ReadLine());
                var measure = Console.ReadLine();

                if (measure == "meters")
                {
                    lenght *= 100;
                }
                
                if (lenght < 20)
                {
                    lenght = 0;
                    brak++; 

                }
                
                
                allLenght += lenght;

            }

           
            var brakLenght = ((n - 1 - brak) * 3);
            allLenght -= brakLenght;
            var students = allLenght / 504;
            

            var restCable = allLenght % 504;

           
            

            Console.WriteLine(students);
            Console.WriteLine(restCable);
        }
    }
}
