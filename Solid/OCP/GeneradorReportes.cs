using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
// Clase que usa la interfaz de Reporte para generar reportes
public class GeneradorReportes
{
    private readonly List<Reporte> reportes;

    public GeneradorReportes()
    {
        reportes = new List<Reporte>();
    }

    public void AgregarReporte(Reporte reporte)
    {
        reportes.Add(reporte);
    }

    public void GenerarTodosReportes()
    {
        foreach (var reporte in reportes)
        {
            reporte.Generar();
        }
    }
}
}