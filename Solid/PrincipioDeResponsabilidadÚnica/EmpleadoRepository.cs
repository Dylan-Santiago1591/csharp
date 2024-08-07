using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipioDeResponsabilidadÚnica
{
// Clase que se encarga de la persistencia de datos del empleado
public class EmpleadoRepository
{
    public void Guardar(Empleado empleado)
    {
        // Lógica para guardar el empleado en la base de datos
        Console.WriteLine($"Empleado {empleado.Nombre} guardado en la base de datos.");
    }
}
}