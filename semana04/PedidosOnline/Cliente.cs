public class Cliente
{
    private string nome;
    private Endereco endereco;

    public Cliente(string nome, Endereco endereco)
    {
        this.nome = nome;
        this.endereco = endereco;
    }

    public string ObterNome()
    {
        return nome;
    }

    public Endereco ObterEndereco()
    {
        return endereco;
    }

    public bool MoraNosEUA()
    {
        return endereco.EstaNosEUA();
    }
}