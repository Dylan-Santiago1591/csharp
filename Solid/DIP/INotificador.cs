using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    // Interfaz para enviar notificaciones
    public interface INotificador
    {
        void EnviarNotificacion(string mensaje);
    }
}