using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase11
{
    public class Servicio : BaseModal, IDescuento
    {
        public decimal AplicarDescuento()
        {
            return Resultado - (Resultado * 0.2m);
        }
    }
}
