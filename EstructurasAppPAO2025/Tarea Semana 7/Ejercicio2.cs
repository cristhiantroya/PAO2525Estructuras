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
        }