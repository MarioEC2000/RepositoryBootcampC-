using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console09
{
    public class Cuadrado : Poligono
    {
        public int lado { get; set; }
        public override void CalcularArea()
        {
            Area = lado * lado;
        }
        public override void CalcularPerimetro()
        {
            Perimetro = 4 * lado;
        }
    }
}
