using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIInterfejsyGeneryczne
{
    public class KolejkaKolowa<T> : DuzaKolejka<T>
    {
        public int pojemnosc { get; set; }
        public KolejkaKolowa(int pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }
        public override void Zapisz(T wartosc)
        {
            base.Zapisz(wartosc);
            if(kolejka.Count > pojemnosc)
            {
                kolejka.Dequeue();
            }
        }
        public override T Czytaj()
        {
            return base.Czytaj();
        }
        public override bool JestPelny => kolejka.Count == pojemnosc;
    }
}
