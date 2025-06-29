//Escribir un programa que almacene en una lista los números del 1 al 10 y 
//los muestre por pantalla en orden inverso separados por comas.


class NumerosInversos
{
    List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
public string ObtenerNumerosInversos()  
    {  
        string resultado = "";  
        for (int i = numeros.Count - 1; i >= 0; i--)  
        {  
            resultado += numeros[i];  
            if (i > 0) resultado += ", ";  
        }  
        return resultado;  
    }  
}  
