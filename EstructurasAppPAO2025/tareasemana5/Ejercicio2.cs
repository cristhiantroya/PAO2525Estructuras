//Escribir un programa que almacene el abecedario en una lista, elimine de la lista las letras que ocupen posiciones múltiplos de 3, 
//y muestre por pantalla la lista resultante.

class Abecedario
{
    List<char> letras = new List<char>()
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
        'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's',
        't', 'u', 'v', 'w', 'x', 'y', 'z'
    };
 public string Filtrar()
    {
        for (int i = letras.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0) letras.RemoveAt(i);
        }
        
        return string.Join(", ", letras);
    }
}