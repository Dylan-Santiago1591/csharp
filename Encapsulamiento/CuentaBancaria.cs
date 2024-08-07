using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
public class CuentaBancaria
{
    // Campos privados
    private string numeroCuenta;
    private decimal saldo;

    // Propiedad pública para acceder al número de cuenta
    public string NumeroCuenta
    {
        get { return numeroCuenta; }
        private set { numeroCuenta = value; } // Solo puede ser establecido dentro de la clase
    }

    // Propiedad pública para acceder y modificar el saldo con lógica adicional
    public decimal Saldo
    {
        get { return saldo; }
        private set
        {
            if (value >= 0) // Validación para asegurar que el saldo no sea negativo
            {
                saldo = value;
            }
            else
            {
                throw new ArgumentException("El saldo no puede ser negativo");
            }
        }
    }

    // Constructor para inicializar los campos
    public CuentaBancaria(string numeroCuenta, decimal saldoInicial)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldoInicial;
    }

    // Método público para depositar dinero
    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depósito de {cantidad:C} realizado. Nuevo saldo: {Saldo:C}");
        }
        else
        {
            throw new ArgumentException("La cantidad a depositar debe ser mayor a cero");
        }
    }

    // Método público para retirar dinero
    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= Saldo)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Retiro de {cantidad:C} realizado. Nuevo saldo: {Saldo:C}");
        }
        else
        {
            throw new ArgumentException("La cantidad a retirar debe ser mayor a cero y menor o igual al saldo disponible");
        }
    }
}
}