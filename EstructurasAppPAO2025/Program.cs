using System;

// La clase Circulo representa un círculo y permite calcular su área y perímetro
public class Circulo
{
    // Variable privada que almacena el radio del círculo
    private double radio;

    // Constructor de la clase, recibe el radio como parámetro
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve el área del círculo utilizando la fórmula: π * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve el perímetro del círculo utilizando la fórmula: 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// La clase Cuadrado representa un cuadrado y permite calcular su área y perímetro
public class Cuadrado
{
    // Variable privada que almacena el lado del cuadrado
    private double lado;

    // Constructor de la clase, recibe el lado como parámetro
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // CalcularArea devuelve el área del cuadrado utilizando la fórmula: lado * lado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // CalcularPerimetro devuelve el perímetro del cuadrado utilizando la fórmula: 4 * lado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

// Clase principal con el método Main para ejecutar el programa
public class Programa
{
    public static void Main()
    {
        // Crear un círculo con radio 5
        Circulo circulo = new Circulo(5);
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + circulo.CalcularPerimetro());

        // Crear un cuadrado con lado 4
        Cuadrado cuadrado = new Cuadrado(4);
        Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + cuadrado.CalcularPerimetro());
    }
}

