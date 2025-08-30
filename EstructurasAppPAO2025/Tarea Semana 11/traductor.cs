public class traductorbasico
{
    public static void run()
    {
        //Creamos el dicccionario 
        Dictionary<string, string> diccionario = new Dictionary<string, string>();
        //Agregamos las palabras iniciales 
        diccionario.Add("time", "tiempo");
        diccionario.Add("person", "persona");
        diccionario.Add("year", "año");
        diccionario.Add("way", "camino");
        diccionario.Add("day", "día");
        diccionario.Add("thing", "cosa");
        diccionario.Add("man", "hombre");
        diccionario.Add("world", "mundo");
        diccionario.Add("life", "vida");
        diccionario.Add("hand", "mano");
        diccionario.Add("part", "parte");
        diccionario.Add("child", "niño");
        diccionario.Add("eye", "ojo");
        diccionario.Add("woman", "mujer");
        diccionario.Add("place", "lugar");
        diccionario.Add("work", "trabajo");
        diccionario.Add("week", "semana");
        diccionario.Add("case", "caso");
        diccionario.Add("point", "punto");
        diccionario.Add("government", "gobierno");
        diccionario.Add("company", "empresa");

        bool salir = false;

        while (!salir)
        {
            // Creamos el menú principal
            System.Console.WriteLine("==================== MENÚ ====================");
            System.Console.WriteLine("1. Traducir una frase");
            System.Console.WriteLine("2. Agregar palabras al diccionario");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opción: ");
            
            string opcion = System.Console.ReadLine();

            switch (opcion)
            {
     case "1":
                    TraducirFrase(diccionario);
                    break;
                case "2":
                    AgregarPalabra(diccionario);
                    break;
                case "0":
                    salir = true;
                    System.Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    System.Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
    }