public class Estudiante
{
    // Campos privados (igual que en Asignatura)
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos = new string[3]; // Array para 3 teléfonos

    // Constructor (misma estructura)
    public Estudiante(int _id, string _nombres, string _apellidos, string _direccion, string[] _telefonos)
    {
        id = _id;
        nombres = _nombres;
        apellidos = _apellidos;
        direccion = _direccion;
        telefonos = _telefonos; // Asignación directa como en el ejemplo
    }

    // Métodos Get (igual que getAsignatura/getNotas)
    public int getId() {
        return id;
    }

    public string getNombres() {
        return nombres;
    }

    public string getApellidos() {
        return apellidos;
    }

    public string getDireccion() {
        return direccion;
    }

    public string[] getTelefonos() {
        return telefonos;
    }
}