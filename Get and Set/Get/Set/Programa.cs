using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Get.Set
{
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de Estudiante
        Estudiante estudiante = new Estudiante();

        // Establecer el nombre del estudiante usando la propiedad
        estudiante.Nombre = "Ana";

        // Mostrar el nombre del estudiante
        estudiante.MostrarNombre();
    }
}
}