using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("Por favor, selecione uma das seguintes opcoes:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que voce gostaria de fazer? ");

            string opcao = Console.ReadLine();
            Console.WriteLine();

            if (opcao == "1")
            {
                string pergunta = gerador.ObterPerguntaAleatoria();
                Console.WriteLine(pergunta);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                string dataAtual = DateTime.Now.ToShortDateString();
                Registro novoRegistro = new Registro(dataAtual, pergunta, resposta);
                diario.AdicionarRegistro(novoRegistro);
            }
            else if (opcao == "2")
            {
                diario.ExibirTodos();
            }
            else if (opcao == "3")
            {
                Console.Write("Qual e o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();
                diario.CarregarDoArquivo(nomeArquivo);
            }
            else if (opcao == "4")
            {
                Console.Write("Qual e o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();
                diario.SalvarNoArquivo(nomeArquivo);
            }
            else if (opcao == "5")
            {
                executando = false;
            }

            Console.WriteLine();
        }
    }
}