using System;
using System.Collections.Generic;

public class Curriculo
{
    public string _nome = "";
    public List<Emprego> _empregos = new List<Emprego>();

    public Curriculo()
    {
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Empregos:");

        foreach (Emprego emp in _empregos)
        {
            emp.Exibir();
        }
    }
}