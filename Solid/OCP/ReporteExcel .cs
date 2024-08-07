using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
// Implementación concreta del reporte Excel
public class ReporteExcel : Reporte
{
    public override void Generar()
    {
        Console.WriteLine("Generando reporte en formato Excel.");
    }
}
}