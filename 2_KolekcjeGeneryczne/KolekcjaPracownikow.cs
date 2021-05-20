using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class KolekcjaPracownikow : IDisplay
    {
        public void Display()
        {
            var Pracownicy  = new DzialyKolekcja();
            Pracownicy.Add("Ksiegowosc", new Pracownik { Nazwisko = "Głowacki" })
                    .Add("Ksiegowosc", new Pracownik { Nazwisko = "Kowal" })
                    .Add("Ksiegowosc", new Pracownik { Nazwisko = "Nowak" })
                    .Add("Ksiegowosc", new Pracownik { Nazwisko = "Głowacki" });
            Pracownicy.Add("Sprzedaż", new Pracownik { Nazwisko = "Nowak"})
                    .Add("Sprzedaż", new Pracownik { Nazwisko = "Nowak"})
                    .Add("Sprzedaż", new Pracownik { Nazwisko = "Dizma"})
                    .Add("Sprzedaż", new Pracownik { Nazwisko = "Kowal" });

            foreach (var Dzial in Pracownicy)
            {
                Console.WriteLine(Dzial.Key);
                foreach (var pracownik in Dzial.Value)
                {
                    Console.WriteLine("\t" + pracownik.Nazwisko);
                }
            }
        }
    }
}
