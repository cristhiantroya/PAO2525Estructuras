//Implementar un método dentro de la Implementar un método dentro de la lista enlazada q lista enlazada que permita invertir los datos ue permita invertir los datos
//almacenados en una lista enlazada, es decir que almacenados en una lista enlazada, es decir que el primer elemento pase a ser el último y el primer elemento pase a ser el último y el
//último pase a ser el primero, que el segundo sea el penúltimo y el penúltimo pase a ser el
//segundo y así segundo y así sucesivamente.

public class ListaSimpleInvertir
{
    NodoInvertir? head;

    public void Invertir()
    {
        NodoInvertir? prev = null;
        NodoInvertir? current = head;
        NodoInvertir? next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        head = prev;
    }

    public void InsertarFinal(int dato)
    {
        NodoInvertir nuevoNodo = new NodoInvertir(dato);
        if (head == null)
            head = nuevoNodo;
        else
        {
            NodoInvertir actual = head;
            while (actual.Next != null)
                actual = actual.Next;
            actual.Next = nuevoNodo;
        }
    }

    public void DibujarLista()
    {
        NodoInvertir? actual = head;
        System.Console.Write("head -->");
        while (actual != null)
        {
            System.Console.Write($" [ {actual.Data} | * ]");
            if (actual.Next != null)
                System.Console.Write(" -->");
            actual = actual.Next;
        }
        System.Console.Write(" --> null \n");
    }
}
