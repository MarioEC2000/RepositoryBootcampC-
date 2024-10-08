using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10.NewFolder
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public int SalarioBase { get; set; }

        public abstract void CalcularSalario();
    }
}
