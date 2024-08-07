using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
// Implementación de la interfaz IAnimal en una clase llamada Perro.
public class Perro : IAnimal
{
    // Implementación de la propiedad Nombre de la interfaz IAnimal.
    public string Nombre { get; set; }

    // Constructor para inicializar la propiedad Nombre.
    public Perro(string nombre)
    {
        Nombre = nombre;
    }

    // Implementación del método HacerSonido de la interfaz IAnimal.
    public void HacerSonido()
    {
        Console.WriteLine("El perro hace: Guau Guau");
    }

    // Implementación del método ObtenerDescripcion de la interfaz IAnimal.
    public string ObtenerDescripcion()
    {
        return $"Este es un perro llamado {Nombre}.";
    }
}
}