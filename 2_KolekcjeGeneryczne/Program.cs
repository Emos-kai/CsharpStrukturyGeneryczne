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
            //IDisplay kolejka = new Kolejka();
            //IDisplay stos = new Stos();
            //HashSet set = new HashSet();
            //set.Display();
            //kolejka.Display();
            //stos.Display();
            //LinkedList lista = new LinkedList();
            //lista.Display();
            //SortedDictionary p = new SortedDictionary();
            //p.Display();
            //IDisplay s = new SortedList();
            //s.Display();
            //IDisplay v = new SortedSet();
            //v.Display();
            //IDisplay slownik = new Dictionary();
            //slownik.Display();
            IDisplay Dzial = new KolekcjaPracownikow();
            Dzial.Display(); 
            
                       
        }
    }
}
