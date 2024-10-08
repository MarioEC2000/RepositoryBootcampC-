using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Ejercicio01
{
    public class EmpleadoContratado : IPagable
    {
        public double PagoporContrato { get; set; }
        public double CalcularPago()
        {
            return PagoporContrato;
        }
    }
}
