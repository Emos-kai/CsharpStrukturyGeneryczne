using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class PracownikComparer : IEqualityComparer<Pracownik>
    {
        public bool Equals(Pracownik x, Pracownik y) => string.Equals(x.Nazwisko, y.Nazwisko);
        public int GetHashCode(Pracownik obj) => obj.Nazwisko.GetHashCode();
    }
}
