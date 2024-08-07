using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace
{
    public class Animal
    {
        // Propiedad de la clase base.
        public string Nombre { get; set; }

        // Constructor para inicializar la propiedad Nombre.
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método virtual que puede ser sobrescrito en las clases derivadas.
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        // Método que no puede ser sobrescrito.
        public void Dormir()
        {
            Console.WriteLine("El animal está durmiendo.");
        }
    }
}