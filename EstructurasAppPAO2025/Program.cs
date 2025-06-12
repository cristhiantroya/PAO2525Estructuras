
public class Program
{
    public static void Main()
    {
        Circulo circulo = new Circulo(5);
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + circulo.CalcularPerimetro());

        Cuadrado cuadrado = new Cuadrado(4);
        Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + cuadrado.CalcularPerimetro());
    }
}


class Estudiante
{
    static void Main(string[] args)
    {
        // 1. Crear estudiante (igual que crear Asignatura)
        string[] telefonosAna = { "0991234567", "022987654", "042111222" };
        Estudiante estudiante1 = new Estudiante(101, "Ana María", "García Pérez", "Calle Principal 456", telefonosAna);

        // 2. Acceder a los datos (usando los métodos get)
        Console.WriteLine("=== DATOS DEL ESTUDIANTE ===");
        Console.WriteLine($"ID: {estudiante1.getId()}");
        Console.WriteLine($"Nombre: {estudiante1.getNombres()} {estudiante1.getApellidos()}");
        Console.WriteLine($"Dirección: {estudiante1.getDireccion()}");

        Console.WriteLine("\nTeléfonos:");
        string[] tels = estudiante1.getTelefonos();
        for (int i = 0; i < tels.Length; i++) {
            Console.WriteLine($"{i+1}. {tels[i]}");
        }
    }
}