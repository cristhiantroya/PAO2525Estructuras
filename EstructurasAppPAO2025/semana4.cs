
public class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    public Contacto(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
    }

    public string MostrarInfo()
    {
        return $"{Nombre}: {Telefono}";
    }
}

public class AgendaTelefonica
{
    private Contacto[] contactos = new Contacto[0];

    public void AgregarContacto(string nombre, string telefono)
    {
        Contacto[] temp = new Contacto[contactos.Length + 1];
        for (int i = 0; i < contactos.Length; i++)
        {
            temp[i] = contactos[i];
        }
        temp[contactos.Length] = new Contacto(nombre, telefono);
        contactos = temp;
        Console.WriteLine("Contacto agregado correctamente");
    }

    public void MostrarContactos()
    {
        if (contactos.Length == 0)
        {
            Console.WriteLine("No hay contactos en la agenda");
            return;
        }

        Console.WriteLine("Lista de contactos:");
        foreach (var contacto in contactos)
        {
            Console.WriteLine(contacto.MostrarInfo());
        }
    }

    public void BuscarContacto(string nombre)
    {
        Contacto encontrado = null;
        for (int i = 0; i < contactos.Length; i++)
        {
            if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = contactos[i];
                break;
            }
        }

        if (encontrado != null)
            Console.WriteLine($"Contacto encontrado: {encontrado.MostrarInfo()}");
        else
            Console.WriteLine("Contacto no encontrado");
    }

    public void EliminarContacto(string nombre)
    {
        int count = 0;
        for (int i = 0; i < contactos.Length; i++)
        {
            if (!contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }

        if (count == contactos.Length)
        {
            Console.WriteLine("No se encontró el contacto");
            return;
        }

        Contacto[] temp = new Contacto[count];
        int index = 0;
        for (int i = 0; i < contactos.Length; i++)
        {
            if (!contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                temp[index++] = contactos[i];
            }
        }
        contactos = temp;
        Console.WriteLine("Contacto eliminado correctamente");
    }
}
