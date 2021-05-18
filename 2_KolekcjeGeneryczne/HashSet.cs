using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class HashSet : IDisplay
    {
        public void Display()
        {
            IEnumerable<int> set = Enumerable.Range(1, 10).ToHashSet();
            set.ToHashSet().Add(10);
            // nie przechowuje duplikatów
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            HashSet<Pracownik> set1 = new HashSet<Pracownik>();
            var pracownik = new Pracownik { Imie = "Marcin" };
            set1.Add(pracownik);
            set1.Add(pracownik);
            set1.Add(new Pracownik { Imie = "Marcin" });
            set1.Add(new Pracownik { Imie = "Marcin" });

            foreach (var item in set1)
            {
                Console.WriteLine(item.Imie);
            }
        }
    }
}
