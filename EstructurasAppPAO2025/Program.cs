Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("=============================");


registrolibros.run();






































//traductorbasico.run();
//Vacunas.run(); 













































//  SistemaAtraccion atraccion = new SistemaAtraccion();
//  System.Console.WriteLine("=== SISTEMA DE ASIGNACIÓN DE ASIENTOS ===");
//  System.Console.WriteLine("Simulando llegada de 30 visitantes...\n");

// for (int i = 1; i <= 30; i++)
// {
//      atraccion.AgregarALaCola($"Visitante-{i}", i);
// }

// System.Console.WriteLine("\nEstado inicial:");
//  atraccion.MostrarCola();

// System.Console.WriteLine("\nIniciando asignación de asientos...");
// atraccion.AsignarAsientos();

// System.Console.WriteLine("\nResultado final de asignación:");
// atraccion.MostrarAsientos();

// System.Console.WriteLine("\nProceso completado exitosamente");















































// Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
// Console.WriteLine("Ejercicio 1");
// string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
// bool balanceada = Ejercicio1.VerificarBalance(expresion);
// Console.WriteLine(balanceada ? "Fórmula balanceada." : "Fórmula NO balanceada.");
// Console.WriteLine("==============================================================");

// Console.WriteLine("Ejercicio 2");
// Ejercicio2.ResolverHanoi(3);  // Llama al método ResolverHanoi del ejercicio 2 para resolver el problema de las Torres de Hanoi con 3 discos.












































// class Program
// {
//     static void Main(string[] args)
//     {
//         // Ejecutar ejercicio 1
//         Console.WriteLine("Ejercicio 1");
//         var listaInvertir = new ListaSimpleInvertir();
//         listaInvertir.InsertarFinal(1);
//         listaInvertir.InsertarFinal(2);
//         listaInvertir.InsertarFinal(3);
//         listaInvertir.DibujarLista();
//         listaInvertir.Invertir();
//         listaInvertir.DibujarLista();

//         // Ejecutar ejercicio 2
//         Console.WriteLine("Ejercicio 2");
//         var listaFiltrar = new ListaSimple();
//         listaFiltrar.GenerarNumerosAleatorios();
//         System.Console.WriteLine("=== Lista original ===");
//         listaFiltrar.DibujarLista();

//         int min = 100, max = 200;
//         System.Console.WriteLine($"\nFiltrando entre {min} y {max}...");
//         listaFiltrar.EliminarFueraDeRango(min, max);
//         System.Console.WriteLine("\n=== Lista filtrada ===");
//         listaFiltrar.DibujarLista();
//     }
// }


































// //ejercicio 1 
// Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
// Console.WriteLine("Ejercicio 1");
// Console.WriteLine("Números en orden inverso: " + new NumerosInversos().ObtenerNumerosInversos());  

// //ejercicio 2 
// Console.WriteLine("Ejercicio 2");
// Console.WriteLine("Abecedario filtrado: " + new Abecedario().Filtrar());

// //ejercicio 3
// Console.WriteLine("Ejercicio 3");
// var miCurso = new Curso();
// var listaAsignaturas = miCurso.ObtenerAsignaturas();

// Console.WriteLine("Asignaturas del curso:");
// foreach (var asignatura in listaAsignaturas)
// {
//     Console.WriteLine($"- {asignatura}");
// }

// Console.WriteLine($"Total de asignaturas: {listaAsignaturas.Count}");

// //ejercicio 4
// Console.WriteLine("Ejercicio 4");
// System.Console.WriteLine("Ingrese una palabra:");
// string entrada = System.Console.ReadLine();

// Palindromo p = new Palindromo();

// if (p.EsPalindromo(entrada))
// {
//     System.Console.WriteLine($"La palabra \"{entrada}\" es un palíndromo.");
// }
// else
// {
//     System.Console.WriteLine($"La palabra \"{entrada}\" NO es un palíndromo.");
// }

// //ejercicio 5
// Console.WriteLine("Ejercicio 5");
// var precios = new Precios();
// Console.WriteLine($"El precio mayor es: {precios.ObtenerMayor()}");
// Console.WriteLine($"El precio menor es: {precios.ObtenerMenor()}");






























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
