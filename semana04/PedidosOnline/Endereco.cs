public class Endereco
{
    private string rua;
    private string cidade;
    private string estado;
    private string pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        this.rua = rua;
        this.cidade = cidade;
        this.estado = estado;
        this.pais = pais;
    }

    public bool EstaNosEUA()
    {
        return pais.Trim().ToLower() == "usa" || pais.Trim().ToLower() == "eua" || pais.Trim().ToLower() == "united states";
    }

    public string ObterEnderecoCompleto()
    {
        return $"{rua}\n{cidade}, {estado}\n{pais}";
    }
}