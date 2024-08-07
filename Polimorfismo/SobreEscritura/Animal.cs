using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SobreEscritura
{
// Clase base
public class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    // Método virtual que puede ser sobrescrito en las clases derivadas
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}
}