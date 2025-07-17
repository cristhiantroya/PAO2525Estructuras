public class Persona
{
    public string Nombre { get; set; } //Propiedad para registrar el nombre de la persona
    public int NumeroTurno { get; set; } // // Propiedad para almacenar el número de turno/orden de llegada
    public Persona(string nombre, int turno) // Constructor para inicializar una persona con nombre y turno
    {
        Nombre = nombre;
        NumeroTurno = turno;
    }
     
     }
public class SistemaAtraccion
{
    private Queue<Persona> colaEspera = new Queue<Persona>(); // Cola para manejar el orden de llegada 
    private List<Persona> asientosAsignados = new List<Persona>(); // Lista para registrar los asientos asignados
    private const int CAPACIDAD = 30;
    public void MostrarCola()
    {
        Console.WriteLine("\n--- PERSONAS EN COLA ---");
        foreach (var persona in colaEspera) // Recorrer cada persona en la cola
        {
            Console.WriteLine($"Turno {persona.NumeroTurno}: {persona.Nombre}");
        }
    }
    public void MostrarAsientos()
    {
        Console.WriteLine("\n--- ASIENTOS ASIGNADOS ---");
        for (int i = 0; i < asientosAsignados.Count; i++) // Recorremos la lista de asientos asignados
        {
            Console.WriteLine($"Asiento {i + 1}: {asientosAsignados[i].Nombre} (Turno {asientosAsignados[i].NumeroTurno})");
        }
    }
    // Método para agregar una nueva persona a la cola
    public void AgregarALaCola(string nombre, int turno)
    {
        if (asientosAsignados.Count < CAPACIDAD)
        {
            colaEspera.Enqueue(new Persona(nombre, turno));
            Console.WriteLine($"{nombre} agregado/a a la cola (Turno {turno})");
        }
        else
        {
            Console.WriteLine("Capacidad máxima alcanzada");
        }
    }
    //Método principal para asignar los asientos
    public void AsignarAsientos()
    {
        Console.WriteLine("\nASIGNANDO ASIENTOS...");
        while (asientosAsignados.Count < CAPACIDAD && colaEspera.Count > 0)
        {
            var persona = colaEspera.Dequeue();
            asientosAsignados.Add(persona);
            Console.WriteLine($"Asiento {asientosAsignados.Count} asignado a {persona.Nombre}");
        }
    }
}
    
    