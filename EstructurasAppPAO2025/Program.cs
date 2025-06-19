
class Program
{
    static void Main()
    {
        AgendaTelefonica miAgenda = new AgendaTelefonica();

        miAgenda.AgregarContacto("Jeeferson Pérez", "095623584");
        miAgenda.AgregarContacto("María García", "0934567890");

        miAgenda.MostrarContactos();

        miAgenda.BuscarContacto("Jefferson Pérez");

        miAgenda.EliminarContacto("María García");

        miAgenda.MostrarContactos();
    }
}








































// using System;

// public class Program
// {
//     public static void Main()
//     {
//         // === FIGURAS GEOMÉTRICAS ===
//         Circulo circulo = new Circulo(5);
//         Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
//         Console.WriteLine("Perímetro del círculo: " + circulo.CalcularPerimetro());

//         Cuadrado cuadrado = new Cuadrado(4);
//         Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
//         Console.WriteLine("Perímetro del cuadrado: " + cuadrado.CalcularPerimetro());

//         // === ESTUDIANTE ===
//         string[] telefonosAna = { "0991234567", "022987654", "042111222" };
//         Estudiante estudiante1 = new Estudiante(101, "Luis Fernando", "Quintero Pérez", "Calle Principal 456", telefonosAna);

//         Console.WriteLine("\n=== DATOS DEL ESTUDIANTE ===");
//         Console.WriteLine($"ID: {estudiante1.getId()}");
//         Console.WriteLine($"Nombre: {estudiante1.getNombres()} {estudiante1.getApellidos()}");
//         Console.WriteLine($"Dirección: {estudiante1.getDireccion()}");

//         Console.WriteLine("\nTeléfonos:");
//         string[] tels = estudiante1.getTelefonos();
//         for (int i = 0; i < tels.Length; i++) {
//             Console.WriteLine($"{i + 1}. {tels[i]}");
//         }
//     }
// }
