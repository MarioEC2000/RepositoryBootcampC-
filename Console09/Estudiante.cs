using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console09
{
    public class Estudiante : Persona
    {
        //Creen una clase Estudiante que tiene codigo de estudiante y agregar una funcionalidad para mostrar todos los datos del estudiante, nombres, apellidos, codigo del estudiante y edad
        public string CodigoEstudiante { get; set; }

        public string MostrarInfo()
        {
            return $"Nombre y Apellidos {Nombre} {Apellidos} Edad {CalcularEdad()} Codigo de estudiante {CodigoEstudiante}";
        }
    }
}
