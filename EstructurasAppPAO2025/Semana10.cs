public class vacunas
{
    public static void run()
    // Crear un conjunto de 500 ciudadanos
        HashSet<string> todosCiudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            todosCiudadanos.Add("Ciudadano " + i);
        }

        Random random = new Random();
         // Crear conjunto de 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        while (pfizer.Count < 75)
{
    int id = random.Next(1, 501);
    pfizer.Add("Ciudadano " + id);
}
// Crear conjunto de 75 vacunados con AstraZeneca
        HashSet<string> astrazeneca = new HashSet<string>();
        while (astrazeneca.Count < 75)
        {
            int id = random.Next(1, 501);
            astrazeneca.Add("Ciudadano " + id);
        }
// Ciudadanos que no se han vacunado
 HashSet<string> noVacunados = new HashSet<string>();
        noVacunados.UnionWith(todosCiudadanos);
        noVacunados.ExceptWith(pfizer);
        noVacunados.ExceptWith(astrazeneca);
        
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
        