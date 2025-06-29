



































// class Program
// {
//     static void Main(string[] args)
//     {
//         const int CAPACIDAD_MAXIMA = 100;
//         Agenda agenda = new Agenda(CAPACIDAD_MAXIMA);
//         bool salir = false;

//         Console.WriteLine("=== AGENDA TELEFÓNICA ===");

//         while (!salir)
//         {
//             Console.WriteLine("\n============================\n");
//             MostrarMenu();
//             string opcion = Console.ReadLine();

//             switch (opcion)
//             {
//                 case "1":
//                     Console.WriteLine("\n============================\n");
//                     AgregarContacto(agenda);
//                     break;
//                 case "2":
//                     agenda.MostrarTodosLosContactos();
//                     break;
//                 case "3":
//                     Console.WriteLine("\n============================\n");
//                     BuscarContacto(agenda);
//                     break;
//                 case "4":
//                     Console.WriteLine("\n============================\n");
//                     EliminarContacto(agenda);
//                     break;
//                 case "5":
//                     salir = true;
//                     break;
//                 default:
//                     Console.WriteLine("\nOpción no válida. Intente nuevamente.");
//                     Console.WriteLine("Presione cualquier tecla para continuar...");
//                     Console.ReadKey();
//                     break;
//             }
//         }

//         Console.WriteLine("\nPrograma terminado. Presione cualquier tecla para salir...");
//         Console.ReadKey();
//     }

//     static void MostrarMenu()
//     {
//         Console.WriteLine("--- MENÚ PRINCIPAL ---");
//         Console.WriteLine("1. Agregar nuevo contacto");
//         Console.WriteLine("2. Mostrar todos los contactos");
//         Console.WriteLine("3. Buscar contacto por nombre");
//         Console.WriteLine("4. Eliminar contacto");
//         Console.WriteLine("5. Salir");
//         Console.Write("\nSeleccione una opción: ");
//     }

//     static void AgregarContacto(Agenda agenda)
//     {
//         Contacto nuevoContacto = new Contacto();

//         Console.WriteLine("--- NUEVO CONTACTO ---");
//         Console.Write("Nombre: ");
//         nuevoContacto.Nombre = Console.ReadLine();
//         Console.Write("Apellido: ");
//         nuevoContacto.Apellido = Console.ReadLine();
//         Console.Write("Teléfono: ");
//         nuevoContacto.Telefono = Console.ReadLine();
//         Console.Write("Email: ");
//         nuevoContacto.Email = Console.ReadLine();
//         Console.Write("Dirección: ");
//         nuevoContacto.Direccion = Console.ReadLine();

//         agenda.AgregarContacto(nuevoContacto);
//     }

//     static void BuscarContacto(Agenda agenda)
//     {
//         Console.Write("Ingrese el nombre a buscar: ");
//         string nombre = Console.ReadLine();
//         agenda.BuscarPorNombre(nombre);
//     }

//     static void EliminarContacto(Agenda agenda)
//     {
//         agenda.MostrarTodosLosContactos();
//         Console.Write("\nIngrese el número del contacto a eliminar: ");
//         if (int.TryParse(Console.ReadLine(), out int indice))
//         {
//             agenda.EliminarContacto(indice - 1);
//         }
//         else
//         {
//             Console.WriteLine("\nEntrada inválida.");
//             Console.WriteLine("Presione cualquier tecla para continuar...");
//             Console.ReadKey();
//         }
//     }
// }





































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
