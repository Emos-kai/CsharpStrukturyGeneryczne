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
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            while(true)
            {
                double wartosc;
                var wartoscWejsciowa = Console.ReadLine();
                if(double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
            kolejka.Zapisz("Marcin");
            double sum = 0.0;
            
            Console.WriteLine("W naszej kolecjce jest: ");
            while (!kolejka.JestPusty)
            {
                var wartosc = kolejka.Czytaj();
                if (wartosc is double)
                    sum += (double)wartosc;
            }
            Console.WriteLine(sum);
            
        }
    }
}
