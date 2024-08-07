using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SobreEscritura
{
// Otra clase derivada que sobrescribe el método HacerSonido
public class Gato : Animal
{
    public Gato(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace: Miau Miau");
    }
}
}