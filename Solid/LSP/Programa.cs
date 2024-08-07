using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
public class Programa
{
    public static void Main(string[] args)
    {
        Ave aguila = new Aguila();
        Ave pinguino = new Pinguino();

        // Aquí está el problema: un pingüino no puede volar, violando el LSP
        aguila.Volar(); // Funciona correctamente
        pinguino.Volar(); // Lanza excepción, lo cual no es esperado
    }
}
}