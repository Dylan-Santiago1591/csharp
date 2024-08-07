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
        Calculadora calc = new Calculadora();

        Console.WriteLine(calc.Sumar(5, 3));       // Llama a Sumar(int, int)
        Console.WriteLine(calc.Sumar(5.5, 3.3));   // Llama a Sumar(double, double)
        Console.WriteLine(calc.Sumar(1, 2, 3));    // Llama a Sumar(int, int, int)
    }
}
}