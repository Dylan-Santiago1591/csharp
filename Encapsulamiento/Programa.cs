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
        // Crear una instancia de CuentaBancaria
        CuentaBancaria miCuenta = new CuentaBancaria("12345678", 1000.00m);

        // Mostrar el número de cuenta y saldo inicial
        Console.WriteLine($"Número de cuenta: {miCuenta.NumeroCuenta}");
        Console.WriteLine($"Saldo inicial: {miCuenta.Saldo:C}");

        // Realizar operaciones en la cuenta
        miCuenta.Depositar(500.00m);
        miCuenta.Retirar(200.00m);

        // Intentar establecer saldo directamente (comentado porque no es posible)
        // miCuenta.Saldo = 3000.00m; // Esto generará un error de compilación

        // Intentar retirar más de lo disponible (comentado para evitar excepción)
        // miCuenta.Retirar(2000.00m); // Esto generará una excepción
    }
}
}