using System;

class Program
{
    static void Main(string[] args)
    {
        int escolha = 0;

        while (escolha != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Atividade de Respiração");
            Console.WriteLine("2. Atividade de Reflexão");
            Console.WriteLine("3. Atividade de Listagem");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção de 1 a 4: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out escolha))
            {
                if (escolha == 1)
                {
                    AtividadeDeRespiracao respiracao = new AtividadeDeRespiracao();
                    respiracao.Executar();
                }
                else if (escolha == 2)
                {
                    AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
                    reflexao.Executar();
                }
                else if (escolha == 3)
                {
                    AtividadeDeListagem listagem = new AtividadeDeListagem();
                    listagem.Executar();
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Até logo!");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                    Console.ReadLine();
                }
            }
        }
    }
}