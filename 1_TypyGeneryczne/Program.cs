using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var kolekaInt = new KolejkaKolowa<int>();
            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);

        }
        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
        {
            double sum = 0.0;
            Console.WriteLine("W naszej kolecjce jest: ");
            while (!kolejka.JestPusty)
            {
                sum += kolejka.Czytaj();
            }
            Console.WriteLine(sum);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
        {
            while (true)
            {
                double wartosc;
                var wartoscWejsciowa = Console.ReadLine();
                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
