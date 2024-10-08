using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Ejercicio01
{
    public class EmpleadoPorHoras : IPagable
    {
        public double CostoPorHora { get; set; }
        public int NumeroHoras { get; set; }
        public double CalcularPago()
        {
            return CostoPorHora * NumeroHoras;
        }
    }
}
