using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Dictionary : IDisplay
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
            Pracownicy.Add("Informatyka", new List<Pracownik>()
            {
                new Pracownik{Nazwisko = "Kowalski"},
                new Pracownik{Nazwisko = "Bogacki"}
            });
            foreach (var item in Pracownicy)
            {
                Console.WriteLine($"Dział {item.Key}");
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }
            }
        }
    }
}
