using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class SortedList : IDisplay
    {
        public void Display()
        {
            var listaPosortowana = new SortedList<int, string>();
            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(2, "dwa");
            //najszybciej jak to jest mozliwe mniej pamieci zuzywa
            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
