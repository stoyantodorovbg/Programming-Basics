using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitOrVagitable
{
    class Program
    {
        static void Main(string[] args)
        {
            var delicacy = Console.ReadLine();
            if (delicacy == "banana" || delicacy == "apple" || delicacy == "kiwi" ||
                delicacy == "cherry" || delicacy == "lemon" || delicacy == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (delicacy == "tomato" || delicacy == "cucumber" ||
                    delicacy == "carrot" || delicacy == "pepper")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
