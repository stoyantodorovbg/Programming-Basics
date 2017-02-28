using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsichkiKarti
{
    class Program
    {
        static void Main(string[] args)
        {
            string kupa = "kupa";
            string karo = "karo";
            string spatiq = "spatiq";
            string pika = "pika";
            string dvoika = "dvoika";
            string troika = "troika";
            string chetvorka = "chetvorka";
            string petica = "petica";
            string shestica = "shestica";
            string sedmica = "sedmica";
            string osmica = "osmica";
            string devetka = "devetka";
            string desetka = "desetka";
            string vale = "vale";
            string dama = "dama";
            string pop = "pop";
            string aso = "aso";
            for (int numbers = 2; numbers <= 14; numbers++)
            {
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 2 && colours == 1)
                    {
                        Console.Write(", " + dvoika + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 3 && colours == 1)
                {
                    Console.Write(", " + troika + " " + kupa);
                }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 4 && colours == 1)
                    {
                        Console.Write(", " + chetvorka + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 5 && colours == 1)
                    {
                        Console.Write(", " + petica + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 6 && colours == 1)
                    {
                        Console.Write(", " + shestica + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 7 && colours == 1)
                    {
                        Console.Write(", " + sedmica + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 8 && colours == 1)
                    {
                        Console.Write(", " + osmica + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 9 && colours == 1)
                    {
                        Console.Write(", " + devetka + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 10 && colours == 1)
                    {
                        Console.Write(", " + desetka + " " + kupa);
                    }
                for (int colours = 1; colours <= 4; colours++)
                    if (numbers == 11 && colours == 1)
                    {
                        Console.Write(", " + vale + " " + kupa);
                    }


            }
        }
    }
}

