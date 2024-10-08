using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console09
{
    public class Rectangulo : Poligono
    {
        public int baseRectangulo { get; set; }
        public int altura { get; set; }
        public override void CalcularArea()
        {
           Area = baseRectangulo * altura;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 4 * (baseRectangulo + altura);
        }
    }
}
