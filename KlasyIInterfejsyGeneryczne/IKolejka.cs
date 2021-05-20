using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIInterfejsyGeneryczne
{
    interface IKolejka<T> : IEnumerable<T>
    {
        bool JestPusty { get; }
        bool JestPelny { get; }
        void Zapisz(T wartosc);
        T Czytaj();
    }
}
