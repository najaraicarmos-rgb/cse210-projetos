public class Produto
{
    private string nome;
    private string idProduto;
    private decimal precoUnitario;
    private int quantidade;

    public Produto(string nome, string idProduto, decimal precoUnitario, int quantidade)
    {
        this.nome = nome;
        this.idProduto = idProduto;
        this.precoUnitario = precoUnitario;
        this.quantidade = quantidade;
    }

    public string ObterNome()
    {
        return nome;
    }

    public string ObterIdProduto()
    {
        return idProduto;
    }

    public decimal CalcularCustoTotal()
    {
        return precoUnitario * quantidade;
    }
}