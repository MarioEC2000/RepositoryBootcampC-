using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase11
{
    public class Producto : BaseModal, IDescuento
    {

        public decimal AplicarDescuento()
        {
            return Resultado - (Resultado * 0.1m);
        }
    }
}
