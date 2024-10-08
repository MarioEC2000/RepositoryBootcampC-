using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Ejercicio01
{
    public class EmpleadoTiempoCompleto : IPagable
    {
        public double salarioFijo { get; set; }
        public double CalcularPago()
        {
            return salarioFijo;
        }
    }
}
