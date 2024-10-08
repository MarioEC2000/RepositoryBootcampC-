using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10.NewFolder
{
    public class EmpleadoporHora : Empleado
    {
        public int PagoPorExtra { get; set; }
        public override void CalcularSalario()
        {
            Console.WriteLine("Su salario es : " + (PagoPorExtra + SalarioBase));
        }
    }
}
