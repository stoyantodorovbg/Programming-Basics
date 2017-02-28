using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontNaPlochki
{
    class Program
    {
        static void Main(string[] args)
        {
            double ploshtadka = double.Parse(Console.ReadLine());
            double  wPlochka = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double wPeika = double.Parse(Console.ReadLine());
            double hPeika = double.Parse(Console.ReadLine());
            if (ploshtadka <= 100 && ploshtadka >= 1 && wPlochka >= 0.1 && wPlochka <= 10 && h >= 0.1 && hPlochka <= 10 && wPeika >= 0 && wPeika <= 10 && hPeika >= 0 && hPeika <= 10)
            {
                var razmerPlochka = wPlochka * h;
                var razmerPloshtadka = ploshtadka * ploshtadka;
                var razmerPeika = wPeika * hPeika;
                var broiPlochki = ((double)razmerPloshtadka / razmerPlochka) - razmerPeika;
                var vreme = broiPlochki * 0.2;
                Console.WriteLine(broiPlochki);
                Console.WriteLine(vreme);
            }
            
        }
    }
}
