using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            // Crear instancia de NotificadorEmail y pasarla al ServicioNotificaciones
            INotificador notificador = new NotificadorEmail();
            ServicioNotificaciones servicio = new ServicioNotificaciones(notificador);

            servicio.Enviar("Hola, esta es una notificación.");
        }
    }
}