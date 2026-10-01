using System;
using System.Collections.Generic;
using System.Threading;

public class AtividadeDeListagem : Atividade
{
    private int _contador;
    private List<string> _perguntas;

    public AtividadeDeListagem()
    {
        _nome = "Atividade de Listagem";
        _descricao = "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.";

        _contador = 0;
        _perguntas = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

    public void ObterPerguntaAleatoria()
    {
        Random random = new Random();
        string pergunta = _perguntas[random.Next(_perguntas.Count)];
        Console.WriteLine($"\n--- {pergunta} ---\n");
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> lista = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duracao);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                lista.Add(item);
                _contador++;
            }
        }
        return lista;
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        ObterPerguntaAleatoria();
        Console.Write("Você começará em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine();

        List<string> itensDoUsuario = ObterListaDoUsuario();

        Console.WriteLine($"\nVocê listou {_contador} itens!");
        ExibirMensagemFinal();
    }
}