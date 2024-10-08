using ConsoleClase15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClase15.Entidades
{
    public class Desarrollador : EmpleadoBase
    {
        public override int SueldoBase => 3000;

        public override decimal CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}
