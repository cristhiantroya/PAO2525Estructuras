// Crear una lista enlazada con 50 números enteros, del 1 al 999 generados aleatoriamente. Una
// vez creada la lista, vez creada la lista, se deben eliminar los nodos qu se deben eliminar los nodos que estén fuera de un r e estén fuera de un rango de valores leídos ango de valores leídos
// desde el teclado.

public class Nodo
{
    public int Data;
    public Nodo? Next;
    public Nodo(int data) => (Data, Next) = (data, null);
}
public class ListaSimple
{
    private Nodo? head;
    private readonly Random random = new Random();


    static ListaSimple()
    {
        ListaSimple lista = new ListaSimple();

       
        lista.GenerarNumerosAleatorios();
        System.Console.WriteLine("=== Lista original ===");
        lista.DibujarLista();

        int min = 100;
        int max = 200;
        System.Console.WriteLine($"\nFiltrando entre {min} y {max}...");

        lista.EliminarFueraDeRango(min, max);
        System.Console.WriteLine("\n=== Lista filtrada ===");
        lista.DibujarLista();
    }
  public void GenerarNumerosAleatorios()
    {
        for (int i = 0; i < 50; i++)
            InsertarFinal(random.Next(1, 1000));
    }

    public void EliminarFueraDeRango(int min, int max)
    {
        while (head != null && (head.Data < min || head.Data > max))
            head = head.Next;

        Nodo? actual = head;
        while (actual != null && actual.Next != null)
        {
            if (actual.Next.Data < min || actual.Next.Data > max)
                actual.Next = actual.Next.Next;
            else
                actual = actual.Next;
        }
    }

    private void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (head == null)
            head = nuevo;
        else
        {
            Nodo actual = head;
            while (actual.Next != null)
                actual = actual.Next;
            actual.Next = nuevo;
        }
    }

    private void DibujarLista()
    {
        Nodo? actual = head;
        System.Console.Write("head -->");
        while (actual != null)
        {
            System.Console.Write($" [ {actual.Data} | * ]");
            if (actual.Next != null) System.Console.Write(" -->");
            actual = actual.Next;
        }
        System.Console.Write(" --> null\n");
    }
}
