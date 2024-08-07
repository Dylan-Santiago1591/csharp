using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP
{
// Clase que implementa solo la interfaz IImpresora
public class Impresora : IImpresora
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo documento.");
    }
}
}