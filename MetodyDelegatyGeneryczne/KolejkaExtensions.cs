using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyDelegatyGeneryczne
{
    public delegate void Drukarka<T>(T dane);
    public static class KolejkaExtensions
    {
        public static IEnumerable<Twyjscie> ElementJako<T, Twyjscie>(this IKolejka<T> kolejka)
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                Twyjscie wynik = (Twyjscie)konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return wynik;
            }
        }
        public static void Print<T> (this IKolejka<T> kolejka, Drukarka<T> wydruk)
        {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }
        }
    }
}
