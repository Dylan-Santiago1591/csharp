// Esta es una clase contenedora pública. Puede contener otras clases.
public class ClaseContenedora
{
    // Esta es una clase privada. Solo es accesible dentro de ClaseContenedora.
    private class ClasePrivada
    {
        // Una propiedad pública dentro de la clase privada.
        public string PropiedadPrivada { get; set; }

        // Un método público dentro de la clase privada.
        public void MetodoPrivado()
        {
            Console.WriteLine("Método privado.");
        }
    }

    // Un método público en la clase contenedora.
    public void MetodoDeClaseContenedora()
    {
        // Crear una instancia de la clase privada.
        ClasePrivada instanciaPrivada = new ClasePrivada();

        // Llamar al método privado de la clase privada.
        instanciaPrivada.MetodoPrivado();
    }
}

// Clase principal para ejecutar el programa.
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase contenedora.
        ClaseContenedora contenedora = new ClaseContenedora();

        // Llamar al método de la clase contenedora, que a su vez llama al método de la clase privada.
        contenedora.MetodoDeClaseContenedora();
    }
}
