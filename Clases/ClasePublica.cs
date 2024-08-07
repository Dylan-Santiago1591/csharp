// Definición de una clase pública
public class ClasePublica
{
    // Propiedad pública, accesible desde cualquier parte
    public string PropiedadPublica { get; set; }

    // Método público, accesible desde cualquier parte
    public void MetodoPublico()
    {
        Console.WriteLine("Método público.");
    }
}

// Programa principal que utiliza la clase pública
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase pública
        ClasePublica instanciaPublica = new ClasePublica();

        // Llamar al método público
        instanciaPublica.MetodoPublico();
    }
}




