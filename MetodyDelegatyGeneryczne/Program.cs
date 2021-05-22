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
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka.elementUsuniety += Kolejka_elementUsuniety;
        }

        private static void Kolejka_elementUsuniety(object sender, ELementUsunietyEventArgs<double> e)
        {
            Console.WriteLine("Kolejka jest pełna. Element usunięty to: {0} Nowy element to {1}", e.ElementUsuniety, e.ElementNowy);
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

