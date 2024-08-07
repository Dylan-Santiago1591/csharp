using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
public class Calculadora
{
    // Método para sumar dos números
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método para restar dos números
    public int Restar(int a, int b)
    {
        return a - b;
    }

    // Método para multiplicar dos números
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    // Método para dividir dos números
    public double Dividir(int a, int b)
    {
        if (b != 0)
        {
            return (double)a / b;
        }
        else
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
    }
}
}