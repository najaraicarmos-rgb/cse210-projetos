using MemorizadorEscrituras;

Referencia referencia = new Referencia("Proverbios", 3, 5, 6);
Escritura escritura = new Escritura(referencia, "Confia no Senhor de todo o teu coracao e nao te estribes no teu proprio entendimento.");

while (true)
{
    Console.Clear();
    Console.WriteLine(escritura.ObterTexto());
    Console.WriteLine();

    if (escritura.EstaCompletamenteEscondida())
    {
        break;
    }

    Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para encerrar:");
    string entrada = Console.ReadLine();

    if (entrada.ToLower() == "sair")
    {
        break;
    }

    escritura.EsconderPalavrasAleatorias(3);
}