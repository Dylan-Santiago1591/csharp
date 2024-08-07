using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Get.Set
{
public class Estudiante
{
    // Atributo privado
    private string nombre;

    // Propiedad para establecer el nombre
    public string Nombre
    {
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }
        }
    }

    // Método para mostrar el nombre del estudiante
    public void MostrarNombre()
    {
        Console.WriteLine($"Nombre del estudiante: {nombre}");
    }
}
}