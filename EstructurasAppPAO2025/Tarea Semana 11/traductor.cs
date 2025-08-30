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
    //metodo para traducir la frase 
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        System.Console.Write("Ingrese la frase a traducir: ");
        string frase = System.Console.ReadLine();

        if (string.IsNullOrEmpty(frase))
        {
            System.Console.WriteLine("No se ingresó ninguna frase.");
            return;
        }
        //Separa la frase en palabras
        string[] palabras = frase.Split(' ');
        string fraseTraducida = "";
        // recorre cada palabra de la frase 
        foreach (string palabra in palabras)
        {
            string palabraLimpia = LimpiarPalabra(palabra);
            // Verifica si la palabra existe en el diccionario
            if (diccionario.ContainsKey(palabraLimpia))
            {
                // si la palabra existe agrega la traduccion 
                fraseTraducida += diccionario[palabraLimpia] + " ";
            }
            else if (diccionario.ContainsValue(palabraLimpia))
            {
                // Buscar la traducción en inglés recorriendo el diccionario para encontrar la clave cuyo valor coincida con la palabra en español

                foreach (var entrada in diccionario)
                {
                    if (entrada.Value == palabraLimpia)
                    {
                        fraseTraducida += entrada.Key + " ";
                        break;
                    }
                }
            }
            else
            {
                fraseTraducida += palabra + " ";
            }
        }

        System.Console.WriteLine("Frase traducida: " + fraseTraducida);
    }
    /// Método para limpiar una palabra
    static string LimpiarPalabra(string palabra)
    {
        string palabraLimpia = palabra.ToLower();
        char[] signosPuntuacion = { '.', ',', ';', ':', '!', '?', '"', '\'' };
        if (signosPuntuacion.Contains(palabraLimpia[palabraLimpia.Length - 1]))
        {
            palabraLimpia = palabraLimpia.Substring(0, palabraLimpia.Length - 1);
        }

        return palabraLimpia;
    }

    }