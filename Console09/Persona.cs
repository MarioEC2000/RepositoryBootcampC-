using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Console09
{
    public class Persona
    {
        //        Además crear una propiedad en la clase persona donde se guarde su fecha de nacimiento y agregar una función que calcule su edad

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected int CalcularEdad()
        {
             DateTime fechaActual = DateTime.Today;
             return fechaActual.Year - FechaNacimiento.Year;
        }
    }
}
