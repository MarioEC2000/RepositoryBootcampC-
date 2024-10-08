using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10
{
    public class CuentaAhorro : Cuenta
    {
        public override void MostrarDetalles()
        {
            Console.WriteLine("Saldo: "+Saldo);
            Console.WriteLine(Titular);
            Console.WriteLine(NumeroCuenta);
        }

        public override void Retirar(decimal monto)
        {
            if (Saldo > monto)
            {
                Saldo = Saldo - monto;
            }
            else
            {
                Console.WriteLine("No cuenta con saldo suficiente!");
            }
        }
    }
}
