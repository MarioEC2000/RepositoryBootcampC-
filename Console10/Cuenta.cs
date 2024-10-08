using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10
{
    public abstract class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Retirar(decimal monto);
        public abstract void MostrarDetalles();
        public void Depositar(decimal monto)
        {
            Saldo = Saldo + monto;
        }
    }
}
