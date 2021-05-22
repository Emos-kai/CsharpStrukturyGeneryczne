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
        public static IEnumerable<Twyjscie> Mapuj<T, Twyjscie>(this IKolejka<T> kolejka, Converter<T, Twyjscie> konweter)
        {
           return kolejka.Select(x => konweter(x));
        }
        public static void Print<T> (this IKolejka<T> kolejka, Action<T> wydruk)
        {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }
        }
    }
}
