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