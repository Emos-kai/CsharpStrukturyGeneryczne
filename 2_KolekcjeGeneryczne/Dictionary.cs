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
            var Pracownicy = new Dictionary<string, HashSet<Pracownik>>();
            Pracownicy.Add("Ksiegowosc", new HashSet<Pracownik>(new PracownikComparer())
            {
                new Pracownik { Nazwisko = "Nowak" },
                new Pracownik { Nazwisko = "Kowal" },
                new Pracownik { Nazwisko = "Kaczor"}
            });
            Pracownicy.Add("Sprzedaz", new HashSet<Pracownik>(new PracownikComparer()) 
            { 
                new Pracownik { Nazwisko = "Kowal" },
                new Pracownik { Nazwisko = "Kiczor" },
                new Pracownik { Nazwisko = "Kowal" },
                new Pracownik { Nazwisko = "Kowal" },

            });
            Pracownicy.Add("Informatyka", new HashSet<Pracownik>(new PracownikComparer())
            {
                new Pracownik { Nazwisko = "Kowalski"},
                new Pracownik {  Nazwisko = "Bogacki"}
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
