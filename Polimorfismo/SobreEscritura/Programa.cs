using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SobreEscritura
{
// Clase principal para ejecutar el programa
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear instancias de Perro y Gato
        Animal miPerro = new Perro("Bobby");
        Animal miGato = new Gato("Michi");

        // Llamar a los métodos HacerSonido
        miPerro.HacerSonido();  // Llama a HacerSonido de Perro
        miGato.HacerSonido();   // Llama a HacerSonido de Gato

        // Uso de polimorfismo: instancias de clases derivadas tratadas como instancias de la clase base
        Animal animal1 = miPerro;
        Animal animal2 = miGato;

        // Llamar a los métodos sobrescritos usando polimorfismo
        animal1.HacerSonido();  // Llama a HacerSonido de Perro
        animal2.HacerSonido();  // Llama a HacerSonido de Gato
    }
}
}