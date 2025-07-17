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
    }
    