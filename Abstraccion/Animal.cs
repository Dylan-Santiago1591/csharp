using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace
{
    // Clase abstracta Animal. No se puede instanciar directamente.
    public abstract class Animal
    {
        // Propiedad pública.
        public string Nombre { get; set; }

        // Constructor para inicializar la propiedad Nombre.
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método abstracto. Las clases derivadas deben proporcionar una implementación.
        public abstract void HacerSonido();

        // Método concreto. Puede ser heredado tal cual por las clases derivadas.
        public void Dormir()
        {
            Console.WriteLine($"{Nombre} está durmiendo.");
        }
    }
}