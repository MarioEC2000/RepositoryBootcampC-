using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    public class Estudiante
    {

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public List<string> Materias { get; set; }
        public List<decimal> Notas { get; set; }


        public decimal CalcularPromedio()
        {
            decimal promedio = 0;

            foreach (var nota in Notas)
            {
                promedio = promedio + nota;
            }

            return promedio / Notas.Count();
        }
    }

    

   
}
