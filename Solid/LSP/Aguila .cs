using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
// Clase derivada que hereda de Ave
public class Aguila : Ave
{
    public override void Volar()
    {
        Console.WriteLine("El águila está volando alto.");
    }
}
}