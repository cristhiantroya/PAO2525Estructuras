public struct Contacto
{
    public string Nombre;
    public string Apellido;
    public string Telefono;
    public string Email;
    public string Direccion;
}
public class Agenda
{
    private Contacto[] contactos;
    private int cantidadContactos;

    public Agenda(int capacidadMaxima)
    {
        contactos = new Contacto[capacidadMaxima];
        cantidadContactos = 0;
    }

    public void AgregarContacto(Contacto nuevoContacto)
    {
        if (cantidadContactos < contactos.Length)
        {
            contactos[cantidadContactos] = nuevoContacto;
            cantidadContactos++;
            Console.WriteLine("\nContacto agregado con éxito!");
        }
        else
        {
            Console.WriteLine("\nLa agenda está llena. No se puede agregar más contactos.");
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    public void MostrarTodosLosContactos()
    {
        Console.WriteLine("\n============================\n");
        if (cantidadContactos == 0)
        {
            Console.WriteLine("No hay contactos en la agenda.");
        }
        else
        {
            Console.WriteLine("--- LISTA DE CONTACTOS ---");
            for (int i = 0; i < cantidadContactos; i++)
            {
                Console.WriteLine($"\nContacto #{i + 1}");
                MostrarContacto(contactos[i]);
            }
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    private void MostrarContacto(Contacto contacto)
    {
        Console.WriteLine($"Nombre: {contacto.Nombre} {contacto.Apellido}");
        Console.WriteLine($"Teléfono: {contacto.Telefono}");
        Console.WriteLine($"Email: {contacto.Email}");
        Console.WriteLine($"Dirección: {contacto.Direccion}");
    }

    public void BuscarPorNombre(string nombre)
    {
        Console.WriteLine("\n============================\n");
        bool encontrado = false;
        
        for (int i = 0; i < cantidadContactos; i++)
        {
            if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                if (!encontrado)
                {
                    Console.WriteLine("--- RESULTADOS DE BÚSQUEDA ---");
                    encontrado = true;
                }
                MostrarContacto(contactos[i]);
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"No se encontraron contactos con el nombre '{nombre}'.");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    public void EliminarContacto(int indice)
    {
        Console.WriteLine("\n============================\n");
        if (indice >= 0 && indice < cantidadContactos)
        {
            for (int i = indice; i < cantidadContactos - 1; i++)
            {
                contactos[i] = contactos[i + 1];
            }
            
            cantidadContactos--;
            Console.WriteLine("\nContacto eliminado con éxito!");
        }
        else
        {
            Console.WriteLine("\nÍndice inválido.");
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}

