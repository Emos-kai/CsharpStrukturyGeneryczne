using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class Kolejka : IDisplay
    {
        public void Display() 
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek" });
            kolejka.Enqueue(new Pracownik { Imie = "Kamil" });
            kolejka.Enqueue(new Pracownik { Imie = "Julia" });
            Console.WriteLine("\nKolejka");
            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
