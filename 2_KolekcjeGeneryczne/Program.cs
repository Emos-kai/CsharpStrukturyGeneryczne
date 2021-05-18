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

            IDisplay kolejka = new Kolejka();
            IDisplay stos = new Stos();
            kolejka.Display();
            stos.Display();
            
        }
    }
}
