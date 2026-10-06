using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>();

        figuras.Add(new Quadrado("Azul", 5.0));
        figuras.Add(new Retangulo("Verde", 4.0, 3.0));
        figuras.Add(new Circulo("Amarelo", 2.0));

        foreach (Figura figura in figuras)
        {
            Console.WriteLine(figura.ObterCor());
            Console.WriteLine(figura.ObterArea());
        }
    }
}