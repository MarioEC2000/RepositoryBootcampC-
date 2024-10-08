using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase12.Notificaciones
{
    public class SMS : INotificacion
    {
        public void Enviar()
        {
            Console.WriteLine("Se envio SMS");
        }
    }
}
