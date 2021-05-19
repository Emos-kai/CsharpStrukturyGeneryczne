using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class SortedSet : IDisplay
    {
        public void Display()
        {
            var set = new SortedSet<int>();
            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);
           
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
