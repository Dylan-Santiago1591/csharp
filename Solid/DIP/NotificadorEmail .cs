using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
// Implementación concreta de la interfaz INotificador
public class NotificadorEmail : INotificador
{
    public void EnviarNotificacion(string mensaje)
    {
        Console.WriteLine($"Enviando notificación por email: {mensaje}");
    }
}
}