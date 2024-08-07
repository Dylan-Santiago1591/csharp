using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
// Clase derivada que hereda de Ave
public class Pinguino : Ave
{
    // Pinguinos no pueden volar, pero deben implementar Volar
    public override void Volar()
    {
        throw new InvalidOperationException("Los pingüinos no pueden volar.");
    }
}
}