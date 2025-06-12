public class Estudiante  // Definición de la clase estudiante
{
    // Campos privados 
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos = new string[3]; // Array para 3 teléfonos

    // Constructor
    public Estudiante(int _id, string _nombres, string _apellidos, string _direccion, string[] _telefonos)
    {
        id = _id;
        nombres = _nombres;
        apellidos = _apellidos;
        direccion = _direccion;
        telefonos = _telefonos; // Asignación del array de teléfonos
    }

    // Métodos públicos que permiten acceder a los valores privados del estudiante

    public int getId()
    {
        return id;
    }

    public string getNombres()
    {
        return nombres;
    }

    public string getApellidos()
    {
        return apellidos;
    }

    public string getDireccion()
    {
        return direccion;
    }

    public string[] getTelefonos()
    {
        return telefonos;
    }
}
