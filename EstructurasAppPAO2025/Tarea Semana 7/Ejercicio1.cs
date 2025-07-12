class Ejercicio1
{
    public static bool VerificarBalance(string expresion) // Método principal que verifica el balance de símbolos de apertura y cierre.
    {
        Stack<char> pila = new Stack<char>(); //Pila para controlar símbolos de apertura.
        foreach (char caracter in expresion) // Recorre cada carácter de la expresión.
        {
            if (esApertura(caracter)) 
            {
                pila.Push(caracter);
            }
            else if (esCierre(caracter))
            {
                if (pila.Count == 0 || !Coinciden(pila.Pop(), caracter))
                    return false;
            }
        }
        return pila.Count == 0;
    }
    // Métodos auxiliares para verificar símbolos
    private static bool esApertura(char c) => c == '{' || c == '[' || c == '(';
    private static bool esCierre(char c) => c == '}' || c == ']' || c == ')';
     private static bool Coinciden(char apertura, char cierre)
    {
        return (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '(' && cierre == ')');
    }

        }