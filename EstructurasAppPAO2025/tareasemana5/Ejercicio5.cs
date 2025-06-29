//Escribir un programa que almacene en una lista los siguientes precios, 50, 75, 46, 22, 80, 65, 8, 
//y muestre por pantalla el menor y el mayor de los precios.

class Precios
{
    List<int> precios = new List<int>() { 50, 75, 46, 22, 80, 65, 8 };

    public int ObtenerMayor()
    {
        int mayor = precios[0];
        foreach (int precio in precios)
        {
            if (precio > mayor) mayor = precio;
        }
        return mayor;
    }
    
    }