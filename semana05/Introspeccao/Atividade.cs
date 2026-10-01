using System;
using System.Threading;

public class Atividade
{
    protected string _nome;
    protected string _descricao;
    protected int _duracao;

    public Atividade()
    {
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à {_nome}.");
        Console.WriteLine();
        Console.WriteLine(_descricao);
        Console.WriteLine();
        Console.Write("Por quanto tempo, em segundos, você deseja para a sua sessão? ");
        _duracao = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Prepare-se...");
        ExibirContagemRegressiva(3);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Bom trabalho!!");
        ExibirProgresso(3);
        Console.WriteLine();
        Console.WriteLine($"Você concluiu a {_nome} por {_duracao} segundos.");
        ExibirProgresso(3);
    }

    public void ExibirProgresso(int segundos)
    {
        List<string> animacao = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(segundos);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animacao[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= animacao.Count)
            {
                i = 0;
            }
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}