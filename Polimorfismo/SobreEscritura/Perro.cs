using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SobreEscritura
{
// Clase derivada que sobrescribe el método HacerSonido
public class Perro : Animal
{
    public Perro(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace: Guau Guau");
    }
}
}