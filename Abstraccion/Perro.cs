using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
// Clase derivada Perro que hereda de la clase abstracta Animal.
public class Perro : Animal
{
    // Constructor que llama al constructor de la clase base.
    public Perro(string nombre) : base(nombre)
    {
    }

    // Implementación del método abstracto HacerSonido.
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace: Guau Guau");
    }

    // Método específico de la clase Perro.
    public void MoverCola()
    {
        Console.WriteLine($"{Nombre} está moviendo la cola.");
    }
}
}