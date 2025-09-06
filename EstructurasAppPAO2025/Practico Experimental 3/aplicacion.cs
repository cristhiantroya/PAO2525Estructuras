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
            Console.WriteLine("\n=== SISTEMA BIBLIOTECA ===");
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