using ConsoleClase15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClase15.Entidades
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public int IdEmpleando { get; set; }
        public string NombreEmpleado { get; set; }
        public string Puesto { get; set; }
        public abstract int SueldoBase { get; }

        private List<EmpleadoBase> empleados { get; set; }

        public abstract decimal CalcularSueldo();

        public void MostrarDetalle(EmpleadoBase empleado)
        {
            Console.WriteLine($"Id Empleado {empleado.IdEmpleando}");
            Console.WriteLine($"Nombre empleado {empleado.NombreEmpleado}");
            Console.WriteLine($"Puesto {empleado.Puesto}");
            Console.WriteLine($"Sueldo {empleado.SueldoBase}");
        }

        public decimal SumaTotal()
        {
            decimal resultado = 0;

            foreach (var empleado in empleados)
            {
                resultado += empleado.CalcularSueldo();
            }

            return resultado;
        }

    }
}
