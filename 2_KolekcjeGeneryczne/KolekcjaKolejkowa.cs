using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class KolekcjaKolejkowa
    {
        private double[] bufor;
        private int poczatekBufora;
        private int koniecBufora;
        public KolekcjaKolejkowa() : this(pojemnosc: 5)
        {

        }
        public KolekcjaKolejkowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;
        }
        public void Zapisz(double wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;
            if (koniecBufora == poczatekBufora)
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
        }
        public double Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }
        public int Pojemnosc
        {
            get => bufor.Length;
        }
        public bool JestPusty
        {
            get => poczatekBufora == koniecBufora;
        }
        public bool JestPelny
        {
            get => (koniecBufora + 1) % bufor.Length == poczatekBufora;
        }
    }
}
