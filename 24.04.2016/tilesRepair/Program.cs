using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tilesRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            double stageLenght = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLenght = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchLenght = double.Parse(Console.ReadLine());

            double tileArea = tileLenght * tileWidth;
            double benchArea = benchLenght * benchWidth;
            double stageArea = stageLenght * stageLenght;
            double alltiles = (stageArea - benchArea) / tileArea;
            double timeForRepair = alltiles * 0.2;

            Console.WriteLine(alltiles);
            Console.WriteLine(timeForRepair);


        }
    }
}
