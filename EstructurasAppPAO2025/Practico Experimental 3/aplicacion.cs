public class registrolibros 
{
    public static void run()
    {
        //Diccionario para almacener los libros 
        Dictionary<string, string> libros = new Dictionary<string, string>();

        // Conjunto para las categorias de los libros 
        HashSet<string> categorias = new HashSet<string>();

        //implementar menú principal del sistema de biblioteca
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== Sistema de registro de libros para biblioteca ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Buscar libro por ISBN");
            Console.WriteLine("3. Mostrar todos los libros");
            Console.WriteLine("4. Agregar categoría");
            Console.WriteLine("5. Mostrar categorías");
            Console.WriteLine("6. Verificar si categoría existe");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarLibro(libros);
                    break;

                case "2":
                    BuscarLibro(libros);
                    break;

                case "3":
                    MostrarLibros(libros);
                    break;

                case "4":
                    AgregarCategoria(categorias);
                    break;

                case "5":
                    MostrarCategorias(categorias);
                    break;

                case "6":
                    VerificarCategoria(categorias);
                    break;

                case "7":
                    continuar = false;
                    Console.WriteLine("¡Gracias por usar el sistema!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

        }
    }
//implementar método AgregarLibro con control de duplicados
static void AgregarLibro(Dictionary<string, string> libros)
    {
        Console.Write("Ingrese el ISBN del libro: ");
        string isbn = Console.ReadLine();
        
        Console.Write("Ingrese el título del libro: ");
        string titulo = Console.ReadLine();
        
        if (libros.ContainsKey(isbn))
        {
            Console.WriteLine("¡Error! Ya existe un libro con ese ISBN.");
        }
        else
        {
            libros.Add(isbn, titulo);
            Console.WriteLine("Libro agregado correctamente.");
        }
    }

    //función para buscar libro por ISBN 
     static void BuscarLibro(Dictionary<string, string> libros)
    {
        Console.Write("Ingrese el ISBN a buscar: ");
        string isbn = Console.ReadLine();
        
        if (libros.ContainsKey(isbn))
        {
            Console.WriteLine("Libro encontrado: " + libros[isbn]);
        }
        else
        {
            Console.WriteLine("No se encontró ningún libro con ese ISBN.");
        }
    }
    //función para mostrar libros registrados 
    static void MostrarLibros(Dictionary<string, string> libros)
    {
        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }
         Console.WriteLine("\n=== LIBROS REGISTRADOS ===");
        foreach (KeyValuePair<string, string> libro in libros)
        {
            Console.WriteLine("ISBN: " + libro.Key + " - Título: " + libro.Value);
        }
        Console.WriteLine("Total de libros: " + libros.Count);
    }
    //función para registrar nuevas categorías
    static void AgregarCategoria(HashSet<string> categorias)
    {
        Console.Write("Ingrese la categoría: ");
        string categoria = Console.ReadLine();
        
        if (categorias.Add(categoria))
        {
            Console.WriteLine("Categoría agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La categoría ya existe.");
        }
    }
    //función para mostrar categorías registradas 
    static void MostrarCategorias(HashSet<string> categorias)
    {
        if (categorias.Count == 0)
        {
            Console.WriteLine("No hay categorías registradas.");
            return;
        }
        
        Console.WriteLine("\n=== CATEGORÍAS ===");
        foreach (string categoria in categorias)
        {
            Console.WriteLine("- " + categoria);
        }
        Console.WriteLine("Total de categorías: " + categorias.Count);
    }
    //función para verificar existencia de categoría
     static void VerificarCategoria(HashSet<string> categorias)
    {
        Console.Write("Ingrese la categoría a verificar: ");
        string categoria = Console.ReadLine();
        
        if (categorias.Contains(categoria))
        {
            Console.WriteLine("La categoría SÍ existe.");
        }
        else
        {
            Console.WriteLine("La categoría NO existe.");
        }
    }
}