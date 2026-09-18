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

    public void EsconderPalavrasAleatorias(int quantidade)
    {
    }

    public string ObterTexto()
    {
        string resultado = _referencia.ObterTexto() + " - ";
        foreach (Palavra p in _palavras)
        {
            resultado += p.ObterTexto() + " ";
        }
        return resultado;
    }

    public bool EstaCompletamenteEscondida()
    {
        return false;
    }
}
