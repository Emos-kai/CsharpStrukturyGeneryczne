using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyDelegatyGeneryczne
{
    public class ELementUsunietyEventArgs<T> : EventArgs
    {
        public T ElementUsuniety { get; set; }
        public T ElementNowy { get; set; }
        public ELementUsunietyEventArgs(T elementUsuniety, T elementNowy)
        {
            ElementUsuniety = elementUsuniety;
            ElementNowy = elementNowy;
        }
    }
}
