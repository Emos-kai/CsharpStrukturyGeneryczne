using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class LinkedList : IDisplay
    {
        public void Display()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}
            LinkedList<int> lista1 = new LinkedList<int>();
            lista1.AddFirst(5);
            lista1.AddFirst(6);
            lista1.AddFirst(7);
            var elementPierwszy = lista1.First;
            var elementOstatni = lista1.Last;
            lista1.AddAfter(elementPierwszy, 10);
            lista1.AddBefore(elementPierwszy, 20);
            var wezel = lista1.First;
            while(wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }
    }
}
