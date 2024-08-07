using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
public class Programa
{
    public static void Main(string[] args)
    {
        GeneradorReportes generador = new GeneradorReportes();

        // Agregar diferentes tipos de reportes sin modificar la clase GeneradorReportes
        generador.AgregarReporte(new ReportePDF());
        generador.AgregarReporte(new ReporteExcel());

        generador.GenerarTodosReportes();
    }
}
}