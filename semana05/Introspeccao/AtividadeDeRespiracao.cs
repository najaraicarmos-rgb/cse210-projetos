using System;
using System.Threading;

public class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao()
    {
        _nome = "Atividade de Respiração";
        _descricao = "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.";
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duracao);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nInspire...");
            ExibirContagemRegressiva(4);

            if (DateTime.Now >= endTime) break;

            Console.Write("\nExpire...");
            ExibirContagemRegressiva(6);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }
}