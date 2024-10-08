using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Ejercicio01
{
    public class Empresa
    {
        public List<IPagable> Empleados { get; set; }
        public List<IDeuda> Clientes { get; set; }

        public void AgregarEmpleado(IPagable empleado)
        {
            Empleados.Add(empleado);
        }

        public double CalcularPagosEmpleados()
        {
            double resultado = 0;

            foreach (var empleado in Empleados)
            {
                resultado += empleado.CalcularPago();
            }

            return resultado;
        }

        public void AgregarCliente(IDeuda cliente)
        {
            Clientes.Add(cliente);
        }

        public decimal CalcularDeudaClientes()
        {
            decimal resultado = 0;

            foreach (var empleado in Clientes)
            {
                resultado += empleado.CalcularDeuda();
            }

            return resultado;
        }
    }
}
