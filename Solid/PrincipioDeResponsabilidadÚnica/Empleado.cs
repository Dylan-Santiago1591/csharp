using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipioDeResponsabilidadÚnica
{
// Clase que se encarga de la lógica de negocio de un empleado
public class Empleado
{
    public string Nombre { get; set; }
    public decimal Salario { get; set; }

    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método para calcular el salario neto (responsabilidad única)
    public decimal CalcularSalarioNeto(decimal impuestos)
    {
        return Salario - impuestos;
    }
}
}