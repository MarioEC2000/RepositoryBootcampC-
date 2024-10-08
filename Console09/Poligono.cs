using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Console09
{
    //class clases abstractas no se instancian
    public abstract class Poligono
    {
        //Crear una clase Poligono que tenga el método CalcularArea,
        //    que tenga la capacidad de calcular el area del cuadrado y el area del rectangulo, usando sobrecarga

        public int Area { get; set; }
        public int Perimetro { get; set; }
        //virtual hace opcional a la hora de sobreescribir metodos
        public virtual void CalcularPerimetro()
        {
            Console.WriteLine("Falta implementar perimetro");
        }
        //abstract hace obligatorio a la hora de sobreescribir metodos
        public abstract void CalcularArea();
    
       
    }
}
