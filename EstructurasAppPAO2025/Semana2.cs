using System;

// La clase Circulo representa un círculo y permite calcular su área y perímetro
public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// La clase Cuadrado representa un cuadrado y permite calcular su área y perímetro
public class Cuadrado
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public double CalcularArea()
    {
        return lado * lado;
    }

    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}