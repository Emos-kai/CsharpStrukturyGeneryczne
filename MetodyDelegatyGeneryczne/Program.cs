using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyDelegatyGeneryczne
{
    class Program
    {
        static void KonsolaWypisz(double dane)
        {
            Console.WriteLine(dane);
        }
        static void Main(string[] args)
        {
            var kolejka = new DuzaKolejka<double>();
            var kolejkaInt = new KolejkaKolowa<double>(pojemnosc: 5);
            WprowadzanieDanych(kolejka);
            kolejka.Print(KonsolaWypisz);
            var elementyJakoInt = kolejka.ElementJako<double, int>();
            PrzetwarzanieDanych(kolejka);
            
        }
        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            double sum = 0.0;
            Console.WriteLine("W naszej kolecjce jest: ");
            while (!kolejka.JestPusty)
            {
                sum += kolejka.Czytaj();
            }
            Console.WriteLine(sum);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
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

