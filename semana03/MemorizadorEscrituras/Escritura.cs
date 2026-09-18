namespace MemorizadorEscrituras;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] pedacos = texto.Split(' ');
        foreach (string pedaco in pedacos)
        {
            _palavras.Add(new Palavra(pedaco));
        }
    }

    public void EsconderPalavrasAleatorias(int numeroParaEsconder)
    {
        Random random = new Random();
        List<Palavra> palavrasVisiveis = _palavras.Where(p => !p.EstaEscondida()).ToList();

        int quantidadeParaEsconder = Math.Min(numeroParaEsconder, palavrasVisiveis.Count);

        for (int i = 0; i < quantidadeParaEsconder; i++)
        {
            int indice = random.Next(palavrasVisiveis.Count);
            palavrasVisiveis[indice].Esconder();
            palavrasVisiveis.RemoveAt(indice);
        }
    }

    public string ObterTexto()
    {
        string textoFormatado = _referencia.ObterTexto() + " - ";
        foreach (Palavra palavra in _palavras)
        {
            textoFormatado += palavra.ObterTexto() + " ";
        }
        return textoFormatado.TrimEnd();
    }

    public bool EstaCompletamenteEscondida()
    {
        return _palavras.All(p => p.EstaEscondida());
    }
}
