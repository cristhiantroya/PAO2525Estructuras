//Escribir un programa que pida al usuario una palabra y muestre por pantalla si es un palíndromo.

class Palindromo
{
    public bool EsPalindromo(string palabra)
    {
        palabra = palabra.ToLower();

        int inicio = 0;
        int fin = palabra.Length - 1;

        while (inicio < fin)
        {
            if (palabra[inicio] != palabra[fin])
            {
                return false;
            }
            inicio++;
            fin--;
        }
        return true;
    }
}