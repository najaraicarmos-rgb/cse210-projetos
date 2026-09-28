using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco("Rua das Palmeiras, 100", "Campinas", "SP", "Brasil");
        Cliente cliente1 = new Cliente("Heitor Matias", endereco1);

        List<Produto> produtos1 = new List<Produto>
        {
            new Produto("Cookies", "P001", 12.00m, 2),
            new Produto("Chocolate Quente", "P002", 15.00m, 1),
            new Produto("Misto Quente", "P003", 10.00m, 2)
        };

        Pedido pedido1 = new Pedido(produtos1, cliente1);

        Endereco endereco2 = new Endereco("Av. Brasil, 1500", "Ribeirão Preto", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Arthur Monteiro", endereco2);

        List<Produto> produtos2 = new List<Produto>
        {
            new Produto("Cookies", "P004", 12.00m, 3),
            new Produto("Misto Quente", "P005", 10.00m, 4)
        };

        Pedido pedido2 = new Pedido(produtos2, cliente2);

        Console.WriteLine("=== PEDIDO 1 ===");
        Console.WriteLine("--- Etiqueta de Embalagem ---");
        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());
        Console.WriteLine("\n--- Etiqueta de Envio ---");
        Console.WriteLine(pedido1.ObterEtiquetaEnvio());
        Console.WriteLine($"\nPreço Total: ${pedido1.CalcularPrecoTotal():F2}");

        Console.WriteLine("\n==================\n");

        Console.WriteLine("=== PEDIDO 2 ===");
        Console.WriteLine("--- Etiqueta de Embalagem ---");
        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());
        Console.WriteLine("\n--- Etiqueta de Envio ---");
        Console.WriteLine(pedido2.ObterEtiquetaEnvio());
        Console.WriteLine($"\nPreço Total: ${pedido2.CalcularPrecoTotal():F2}");
    }
}