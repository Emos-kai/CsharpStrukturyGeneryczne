using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //var liczby = new List<int>();
            //var pojemnosc = -1;
            //while (true)
            //{
            //    if (liczby.Capacity != pojemnosc)
            //    {
            //        pojemnosc = liczby.Capacity;
            //        Console.WriteLine(pojemnosc);
            //    }
            //    liczby.Add(1);
            //}
            Queue<Pracownik> Kolejka = new Queue<Pracownik>();
            Kolejka.Enqueue(new Pracownik { Imie = "Marcin" });
            Kolejka.Enqueue(new Pracownik { Imie = "Tomek" });
            Kolejka.Enqueue(new Pracownik { Imie = "Kamil" });
            Kolejka.Enqueue(new Pracownik { Imie = "Julia" });
            while(Kolejka.Count > 0)
            {
                var pracownik = Kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
