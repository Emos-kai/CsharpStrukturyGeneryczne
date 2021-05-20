using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class DzialyKolekcja : SortedDictionary<string, HashSet<Pracownik>>
    {
        public DzialyKolekcja Add(string nazwaDzialu, Pracownik pracownik)
        {
            if (!ContainsKey(nazwaDzialu))
            {
                Add(nazwaDzialu, new HashSet<Pracownik>(new PracownikComparer())); 
            }
            this[nazwaDzialu].Add(pracownik);
            return this;
        }
    }
}
