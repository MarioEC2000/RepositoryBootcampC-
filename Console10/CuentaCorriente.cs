using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10
{
    public class CuentaCorriente : Cuenta
    {
        public override void MostrarDetalles()
        {
            Console.WriteLine("Saldo :"+Saldo);
            Console.WriteLine(Titular);
            Console.WriteLine(NumeroCuenta);
        }

        public override void Retirar(decimal monto)
        {
            decimal comision = 0.02m;
            Saldo = Saldo - monto - (monto * comision) ;
        }

        
    }
}
