using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase11
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int NumeroDocumento { get; set; }
        public decimal Sueldo { get; set; }

        public decimal DescuentoSueldo()
        {
            return Sueldo - (Sueldo * 0.05m);
        }

    }
}
