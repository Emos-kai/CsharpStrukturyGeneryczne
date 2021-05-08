using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa<T>
    {
        private T[] bufor;
        private int pocztekBufora;
        private int koniecBufora;
        public KolejkaKolowa() : this(pojemnosc: 5)
        {
        }
        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T[pojemnosc + 1];
            pocztekBufora = 0;
            koniecBufora = 0;
        }
        public void Zapisz(T wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;

            if (koniecBufora == pocztekBufora)
                pocztekBufora = (pocztekBufora + 1) % bufor.Length;
        }
        public T Czytaj()
        {
            var wynik = bufor[pocztekBufora];
            pocztekBufora = (pocztekBufora + 1) % bufor.Length;
            return wynik;
        }
        public int Pojemnosc
        {
           get => bufor.Length;
        }

        public bool JestPusty
        {
            get => koniecBufora == pocztekBufora;  
        }

        public bool JestPelny
        {
            get => (koniecBufora + 1) % bufor.Length == pocztekBufora;
        }
    }
}
