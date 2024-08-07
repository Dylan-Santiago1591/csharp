using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Get
{
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de Rectangulo
        Rectangulo rectangulo = new Rectangulo(5.0, 3.0);

        // Obtener y mostrar el área del rectángulo
        Console.WriteLine($"Área del rectángulo: {rectangulo.Area}");
    }
}
}