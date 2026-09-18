namespace MemorizadorEscrituras;

public class Palavra
{
    private string _texto;
    private bool _estaEscondida;

    public Palavra(string texto)
    {
        _texto = texto;
        _estaEscondida = false;
    }

    public void Esconder()
    {
        _estaEscondida = true;
    }

    public void Exibir()
    {
        _estaEscondida = false;
    }

    public bool EstaEscondida()
    {
        return _estaEscondida;
    }

    public string ObterTexto()
    {
        if (_estaEscondida)
        {
            return new string('_', _texto.Length);
        }
        return _texto;
    }
}
