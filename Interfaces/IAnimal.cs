using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    // Definición de la interfaz. Las interfaces en C# se definen con la palabra clave 'interface'.
public interface IAnimal
{
    // Declaración de una propiedad. Todas las propiedades en una interfaz son públicas por defecto.
    string Nombre { get; set; }

    // Declaración de un método. Todos los métodos en una interfaz son públicos por defecto.
    void HacerSonido();

    // Declaración de un método que retorna un valor.
    string ObtenerDescripcion();
}
}