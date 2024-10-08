using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Ejercicio01
{
    public class ClienteClasico : IDeuda
    {
        public int CostoServicio { get; set; }

        public decimal CalcularDeuda()
        {
            return CostoServicio * 1.25m;
        }
    }
}
