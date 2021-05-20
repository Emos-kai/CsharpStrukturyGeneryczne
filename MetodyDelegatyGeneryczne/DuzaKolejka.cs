using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MetodyDelegatyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka;
        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }
        public virtual bool JestPusty => kolejka.Count == 0;
        public virtual bool JestPelny => throw new System.NotImplementedException();
        public virtual T Czytaj() => kolejka.Dequeue();
        public virtual void Zapisz(T wartosc) => kolejka.Enqueue(wartosc);
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in kolejka)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => kolejka.GetEnumerator();
       
    }
}
