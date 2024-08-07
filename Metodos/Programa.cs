using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de Calculadora
        Calculadora calc = new Calculadora();

        // Llamar a los métodos y mostrar los resultados
        Console.WriteLine($"Suma: {calc.Sumar(10, 5)}");
        Console.WriteLine($"Resta: {calc.Restar(10, 5)}");
        Console.WriteLine($"Multiplicación: {calc.Multiplicar(10, 5)}");
        Console.WriteLine($"División: {calc.Dividir(10, 5)}");
    }
}
}