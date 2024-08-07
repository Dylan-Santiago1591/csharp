// Esta es una clase internal. Solo es accesible dentro del mismo ensamblado.
internal class ClaseInternal
{
    // Una propiedad pública dentro de la clase internal.
    public string PropiedadInternal { get; set; }

    // Un método público dentro de la clase internal.
    public void MetodoInternal()
    {
        Console.WriteLine("Método internal.");
    }
}

// Clase principal para ejecutar el programa.
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase internal.
        ClaseInternal instanciaInternal = new ClaseInternal();

        // Llamar al método internal de la clase internal.
        instanciaInternal.MetodoInternal();
    }
}
