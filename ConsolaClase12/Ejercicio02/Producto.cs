using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Ejercicio02
{
    public class Producto : IPedidos
    {
        public Provedor Proveedor { get; set; }

        public void EnviarPedido()
        {
            Console.WriteLine("Enviar pedido " + Proveedor.RazonSocial);
        }
    }
}
