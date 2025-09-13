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
    public static void run()
    {

    }

}