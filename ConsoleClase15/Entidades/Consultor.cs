using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClase15.Entidades
{
    public class Consultor : EmpleadoBase
    {
        public override int SueldoBase => 5000;

        public override decimal CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}
