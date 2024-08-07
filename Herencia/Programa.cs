using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase Perro.
        Perro miPerro = new Perro("Bobby");
        // Llamar a los métodos de la clase Perro y de la clase base.
        miPerro.HacerSonido();
        miPerro.MoverCola();
        miPerro.Dormir();

        // Crear una instancia de la clase Gato.
        Gato miGato = new Gato("Michi");
        // Llamar a los métodos de la clase Gato y de la clase base.
        miGato.HacerSonido();
        miGato.Ronronear();
        miGato.Dormir();

        // Usar polimorfismo: instancias de clases derivadas tratadas como instancias de la clase base.
        Animal animal1 = miPerro;
        Animal animal2 = miGato;

        // Llamar a los métodos sobrescritos.
        animal1.HacerSonido();  // Llamará al método HacerSonido de Perro.
        animal2.HacerSonido();  // Llamará al método HacerSonido de Gato.
    }
}
}