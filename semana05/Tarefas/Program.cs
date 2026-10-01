using System;

class Program
{
    static void Main(string[] args)
    {
        // Teste da Tarefa base
        Tarefa tarefa1 = new Tarefa("Rafael Carmo", "Matemática Básica");
        Console.WriteLine(tarefa1.ObterResumo());

        // Teste da Tarefa de Matemática
        TarefaDeMatematica tarefaMatematica = new TarefaDeMatematica("Rafael Carmo", "Tabuada", "5", "1-10");
        Console.WriteLine(tarefaMatematica.ObterResumo());
        Console.WriteLine(tarefaMatematica.ObterListaDeTarefas());

        // Teste da Tarefa de Redação
        TarefaDeRedacao tarefaRedacao = new TarefaDeRedacao("Rafael Carmo", "Atualidades", "O Impacto do Uso das Redes Sociais");
        Console.WriteLine(tarefaRedacao.ObterResumo());
        Console.WriteLine(tarefaRedacao.ObterInformacoesDaRedacao());
    }
}