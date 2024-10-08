using ConsoleClase15.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClase15.Interface
{
    public interface IEmpleado
    {
        public decimal CalcularSueldo();
        public void MostrarDetalle(EmpleadoBase empleado);
    }
}
