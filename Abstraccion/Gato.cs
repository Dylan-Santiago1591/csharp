using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
// Otra clase derivada Gato que hereda de la clase abstracta Animal.
public class Gato : Animal
{
    // Constructor que llama al constructor de la clase base.
    public Gato(string nombre) : base(nombre)
    {
    }

    // Implementación del método abstracto HacerSonido.
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace: Miau Miau");
    }

    // Método específico de la clase Gato.
    public void Ronronear()
    {
        Console.WriteLine($"{Nombre} está ronroneando.");
    }
}
}