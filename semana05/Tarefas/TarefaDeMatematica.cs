public class TarefaDeMatematica : Tarefa
{
    private string _textoCapitulo;
    private string _problemas;

    public TarefaDeMatematica(string nomeEstudante, string topico, string textoCapitulo, string problemas) : base(nomeEstudante, topico)
    {
        _textoCapitulo = textoCapitulo;
        _problemas = problemas;
    }

    public string ObterListaDeTarefas()
    {
        return $"Capítulo {_textoCapitulo} Problemas {_problemas}";
    }
}