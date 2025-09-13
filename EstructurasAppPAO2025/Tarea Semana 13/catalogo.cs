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
    //// Búsqueda ITERATIVA en arreglo
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

    }

}