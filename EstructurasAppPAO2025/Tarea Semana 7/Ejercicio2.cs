class Ejercicio2
{
    public static void ResolverHanoi(int discos)
    {
        // Crear las 3 torres (pilas)
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        for (int i = discos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("=== Estado Inicial ===");
        MostrarTorres(torreA, torreB, torreC);

        // Llamar a la función recursiva
        MoverDiscos(discos, torreA, torreC, torreB, "A", "C", "B");
    }
    private static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar) // Método para mover discos entre torres
    {
        if (n > 0)
        {
           
         MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino); // Mover n-1 discos de origen a auxiliar usando destino como auxiliar
          // Mover el disco restante (el más grande) de la torre 'origen' a la torre 'destino'.
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"\nMover disco {disco} de {nombreOrigen} a {nombreDestino}");
            MostrarTorres(origen, auxiliar, destino);
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen); //Mover los n-1 discos desde la torre 'auxiliar' a la torre 'destino', usando la torre 'origen' como soporte temporal.
        }
    }
    // Método para mostrar el estado actual de las torres
      private static void MostrarTorres(Stack<int> torreA, Stack<int> torreB, Stack<int> torreC)
    {
        Console.WriteLine("\nTorre A: " + string.Join(", ", torreA.Reverse()));
        Console.WriteLine("Torre B: " + string.Join(", ", torreB.Reverse()));
        Console.WriteLine("Torre C: " + string.Join(", ", torreC.Reverse()));
    }
}
        