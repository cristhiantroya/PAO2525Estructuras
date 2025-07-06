// Implementar un método dentro de la Implementar un método dentro de la lista enlazada q lista enlazada que permita invertir los datos ue permita invertir los datos
// almacenados en una lista enlazada, es decir que almacenados en una lista enlazada, es decir que el primer elemento pase a ser el último y el primer elemento pase a ser el último y el
// último pase a ser el primero, que el segundo sea el penúltimo y el penúltimo pase a ser el
// segundo y así segundo y así sucesivamente. 

public class ListaSimple
{
    Nodo? head;
    public void Invertir()
    {
        Nodo? prev = null;
        Nodo? current = head;
        Nodo? next = null;

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
        Nodo nuevoNodo = new Nodo(dato);
        if (head == null)
            head = nuevoNodo;
        else
        {
            Nodo actual = head;
            while (actual.Next != null)
                actual = actual.Next;
            actual.Next = nuevoNodo;
        }
    }
}