public class catalogoderevistas
{
        private string[] revistas;
        private int cantidad;
        public catalogoderevistas ()
        {
             revistas = new string[20];
              cantidad = 0;
              }
    //añadir método Insertar para agregar títulos en el arreglo de revistas
        public void Insertar(string titulo)
    {
        if (cantidad < revistas.Length)
        {
            revistas[cantidad] = titulo;
            cantidad++;
        }
    }  
    // Búsqueda iterativa
      public bool BuscarIterativo(string titulo)
    {
        for (int i = 0; i < cantidad; i++)
        {
            if (revistas[i] == titulo)
            {
                return true;
            }
        }
        return false;
    }
    public static void run()
    {
        catalogoderevistas catalogo = new catalogoderevistas();
        //insertamos 10 revistas populares en el catálogo

        catalogo.Insertar("National Geographic");
        catalogo.Insertar("Nature");
        catalogo.Insertar("Science");
        catalogo.Insertar("Forbes");
        catalogo.Insertar("Vogue");
        catalogo.Insertar("People");
        catalogo.Insertar("Marca");
        catalogo.Insertar("Mundo deportivo");
        catalogo.Insertar("Sport Life");
        catalogo.Insertar("The Economist");
        //implementar menú de opciones para buscar títulos  
         
    bool continuar = true;
        
        while (continuar)
        {
            System.Console.WriteLine("\n--- Catálogo de Revistas ---");
            System.Console.WriteLine("1. Buscar título");
            System.Console.WriteLine("2. Salir");
            System.Console.Write("Seleccione una opción: ");
            
            string opcion = System.Console.ReadLine();
    }

}