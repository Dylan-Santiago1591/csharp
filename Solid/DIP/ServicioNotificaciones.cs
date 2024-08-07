using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
// Clase que depende de la interfaz INotificador
public class ServicioNotificaciones
{
    private readonly INotificador notificador;

    public ServicioNotificaciones(INotificador notificador)
    {
        this.notificador = notificador;
    }

    public void Enviar(string mensaje)
    {
        notificador.EnviarNotificacion(mensaje);
    }
}
}