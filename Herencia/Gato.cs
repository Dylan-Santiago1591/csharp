using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
public class Gato : Animal
{
    // Constructor que llama al constructor de la clase base.
    public Gato(string nombre) : base(nombre)
    {
    }

    // Sobrescribir el método HacerSonido de la clase base.
    public override void HacerSonido()
    {
        Console.WriteLine("El gato hace: Miau Miau");
    }

    // Método específico de la clase Gato.
    public void Ronronear()
    {
        Console.WriteLine("El gato está ronroneando.");
    }
}
}