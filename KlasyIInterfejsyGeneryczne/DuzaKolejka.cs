using System.Collections.Generic;

namespace KlasyIInterfejsyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka;
        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }
        public virtual bool JestPusty
        {
            get => kolejka.Count == 0;
        }
        public virtual bool JestPelny => throw new System.NotImplementedException();
        public virtual T Czytaj() => kolejka.Dequeue();
        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }
    }
}