using System;
using System.Collections.Generic;
using System.Threading;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao()
    {
        _nome = "Atividade de Reflexão";
        _descricao = "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência.";

        _reflexoes = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência?",
            "O que você aprendeu sobre si mesmo?"
        };
    }

    public string ObterReflexoesAleatorias()
    {
        Random random = new Random();
        int index = random.Next(_reflexoes.Count);
        return _reflexoes[index];
    }

    public string ObterPerguntasAleatorias()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        return _perguntas[index];
    }

    public void ExibirReflexoes()
    {
        string reflexao = ObterReflexoesAleatorias();
        Console.WriteLine($"\n--- {reflexao} ---\n");
    }

    public void ExibirPerguntas()
    {
        string pergunta = ObterPerguntasAleatorias();
        Console.Write($"> {pergunta} ");
        ExibirProgresso(5);
        Console.WriteLine();
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine("\nConsidere o seguinte:");
        ExibirReflexoes();
        Console.WriteLine("Quando tiver isso em mente, pressione Enter para continuar.");
        Console.ReadLine();

        Console.WriteLine("Agora pondere sobre cada uma das seguintes perguntas:");
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duracao);

        while (DateTime.Now < endTime)
        {
            ExibirPerguntas();
        }

        ExibirMensagemFinal();
    }
}