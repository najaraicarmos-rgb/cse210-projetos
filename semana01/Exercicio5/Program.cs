using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();

        string nomeUsuario = PerguntarNomeUsuario();
        int numeroFavorito = PerguntarNumeroFavorito();

        int quadrado = ElevarAoQuadrado(numeroFavorito);

        ExibirResultado(nomeUsuario, quadrado);
    }

    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-vindo ao programa!");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();
        return nome;
    }

    static int PerguntarNumeroFavorito()
    {
        Console.Write("Por favor, insira seu número favorito: ");
        int numero = int.Parse(Console.ReadLine());
        return numero;
    }

    static int ElevarAoQuadrado(int numero)
    {
        int resultado = numero * numero;
        return resultado;
    }

    static void ExibirResultado(string nome, int quadrado)
    {
        Console.WriteLine($"{nome}, o quadrado do seu número é {quadrado}");
    }
}