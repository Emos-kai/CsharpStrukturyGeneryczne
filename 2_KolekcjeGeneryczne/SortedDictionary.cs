using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class SortedDictionary : IDisplay
    {
        public void Display()
        {
            var Pracownicy = new Dictionary<string, List<Pracownik>>();
            Pracownicy.Add("Ksiegowosc", new List<Pracownik>()
            {
                new Pracownik { Nazwisko = "Nowak" },
                new Pracownik { Nazwisko = "Kowla" },
                new Pracownik { Nazwisko = "Kaczor"}
            });
            Pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });
            Pracownicy.Add("Sprzedaz", new List<Pracownik>
            {
                new Pracownik { Imie = "Jan", Nazwisko = "Kowal" }
            });
            Pracownicy.Add("Informatyka", new List<Pracownik>()
            {
                new Pracownik{Imie = "Kamil", Nazwisko = "Kowalski"},
                new Pracownik{Imie = "Jan", Nazwisko = "Bogacki"}
            });
            foreach (var item in Pracownicy)
            {
                Console.WriteLine($"{item.Key}, {item.Value.Count}");
            }
        }
    }
}
