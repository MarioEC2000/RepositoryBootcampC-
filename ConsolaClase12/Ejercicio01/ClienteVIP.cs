using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Ejercicio01
{
    public  class ClienteVIP : IDeuda
    {
        public int CostoServicio { get; set; }
        public int DescuentoVip { get; set; }

        public decimal CalcularDeuda()
        {
            return CostoServicio - DescuentoVip;
        }
        //decimal CalcularDeuda()
        //{
        //   return CostoServicio * 0.75m - DescuentoVip;
        //}
    }
}
