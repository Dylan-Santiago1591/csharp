using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Get
{
public class Rectangulo
{
    // Atributos privados
    private double largo;
    private double ancho;

    // Constructor para inicializar los atributos
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    // Propiedad para obtener el área del rectángulo
    public double Area
    {
        get { return largo * ancho; }
    }
}
}