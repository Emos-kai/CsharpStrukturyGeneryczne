using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class Stos : IDisplay
    {
        public void Display()
        {
            Stack<Pracownik> Stos = new Stack<Pracownik>();
            Stos.Push(new Pracownik { Imie = "Marcin" });
            Stos.Push(new Pracownik { Imie = "Tomek" });
            Stos.Push(new Pracownik { Imie = "Kamil" });
            Stos.Push(new Pracownik { Imie = "Julia" });
            Console.WriteLine("\nStos");
            while (Stos.Count > 0)
            {
                var pracownik = Stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
