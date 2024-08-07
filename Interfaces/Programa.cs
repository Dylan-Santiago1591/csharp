using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
// Clase principal para ejecutar el programa.
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase Perro e inicializarla con un nombre.
        IAnimal miPerro = new Perro("Bobby");
        // Llamar a los métodos implementados de la interfaz IAnimal.
        miPerro.HacerSonido();
        Console.WriteLine(miPerro.ObtenerDescripcion());

        // Crear una instancia de la clase Gato e inicializarla con un nombre.
        IAnimal miGato = new Gato("Michi");
        // Llamar a los métodos implementados de la interfaz IAnimal.
        miGato.HacerSonido();
        Console.WriteLine(miGato.ObtenerDescripcion());
    }
}
}