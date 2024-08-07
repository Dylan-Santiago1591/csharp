using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipioDeResponsabilidadÚnica
{
public class Programa
{
    public static void Main(string[] args)
    {
        Empleado empleado = new Empleado("Pedro", 5000);
        decimal salarioNeto = empleado.CalcularSalarioNeto(500);

        EmpleadoRepository repo = new EmpleadoRepository();
        repo.Guardar(empleado);

        Console.WriteLine($"Salario neto de {empleado.Nombre}: {salarioNeto:C}");
    }
}
}