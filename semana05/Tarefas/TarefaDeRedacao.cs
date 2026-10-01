public class TarefaDeRedacao : Tarefa
{
    private string _tituloRedacao;

    public TarefaDeRedacao(string nomeEstudante, string topico, string tituloRedacao) : base(nomeEstudante, topico)
    {
        _tituloRedacao = tituloRedacao;
    }

    public string ObterInformacoesDaRedacao()
    {
        return $"{_tituloRedacao}, por {ObterNomeEstudante()}";
    }
}