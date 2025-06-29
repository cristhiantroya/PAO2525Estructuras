//Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
//en una lista y la muestre por pantalla.
class Curso
{
    private List<string> asignaturas = new List<string>()
    {
        "Matemáticas",
        "Física",
        "Química",
        "Historia",
        "Lengua"
    };
     public List<string> ObtenerAsignaturas()
    {
        return asignaturas;
    }
}

