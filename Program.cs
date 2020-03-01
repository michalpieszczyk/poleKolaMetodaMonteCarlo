using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczenieWstepne
{
    class Program
    {
        static void Main(string[] args)
        {
            int promien;
            int iloscPunktow;
            int ileTrafilo = 0;
            Random random = new Random();
            double odleglosc;
            double promien2;
        
            double x;
            double y;

            Console.WriteLine("Podaj promień okręgu: (INT) ");
            promien = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Podaj ilość punktów do wylosowania: (INT) ");
            iloscPunktow = int.Parse(Console.ReadLine());
            promien2 = Convert.ToDouble(promien);

            for (int i=0; i <= iloscPunktow; i++)
            {
                x = random.Next(-promien, promien) + random.NextDouble();
                y = random.Next(-promien, promien) + random.NextDouble();

                odleglosc = Math.Sqrt(x * x + y * y);

                if (odleglosc <= promien2)
                {
                    ileTrafilo++;
                }
            }

            double pole = 0;
            pole = promien * promien * Math.PI;

            double pole2 = 0;
            pole2 = 4 * promien2 * promien2 * (Convert.ToDouble(ileTrafilo) / Convert.ToDouble(iloscPunktow));
            Console.WriteLine();
            Console.WriteLine("Pole normalnie: " + pole);
            Console.WriteLine();
            Console.WriteLine("Pole monte carlo: " + pole2);
            Console.ReadKey();
        }
    }
}
