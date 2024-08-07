using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
public class Perro : Animal
{
    // Constructor que llama al constructor de la clase base.
    public Perro(string nombre) : base(nombre)
    {
    }

    // Sobrescribir el método HacerSonido de la clase base.
    public override void HacerSonido()
    {
        Console.WriteLine("El perro hace: Guau Guau");
    }

    // Método específico de la clase Perro.
    public void MoverCola()
    {
        Console.WriteLine("El perro está moviendo la cola.");
    }
}
}