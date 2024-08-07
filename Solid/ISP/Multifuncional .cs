using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP
{
// Clase que implementa ambas interfaces
public class Multifuncional : IImpresora, IFax
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo documento.");
    }

    public void EnviarFax()
    {
        Console.WriteLine("Enviando fax.");
    }
}
}