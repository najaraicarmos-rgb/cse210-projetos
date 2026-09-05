using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a porcentagem da sua nota? ");
        string entrada = Console.ReadLine();
        int percentual = int.Parse(entrada);

        string letra = "";

        if (percentual >= 90)
        {
            letra = "A";
        }
        else if (percentual >= 80)
        {
            letra = "B";
        }
        else if (percentual >= 70)
        {
            letra = "C";
        }
        else if (percentual >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        string sinal = "";
        int ultimoDigito = percentual % 10;

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }

        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }
        else if (letra == "F")
        {
            sinal = "";
        }

        Console.WriteLine();
        Console.WriteLine($"Sua nota conceitual é: {letra}{sinal}");

        if (percentual >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado no curso!");
        }
        else
        {
            Console.WriteLine("Não foi desta vez, mas continue se esforçando para a próxima!");
        }
    }
}