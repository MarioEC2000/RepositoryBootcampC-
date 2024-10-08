using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console09
{
    public class Triangulo : Poligono
    {
        public int altura { get; set; }
        public int baseTriangulo { get; set; }

        public override void CalcularArea()
        {
            Area = (altura * baseTriangulo) / 2;
        }

    }
}
