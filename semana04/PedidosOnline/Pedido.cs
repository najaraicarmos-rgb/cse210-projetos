using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> produtos;
    private Cliente cliente;

    public Pedido(List<Produto> produtos, Cliente cliente)
    {
        this.produtos = produtos;
        this.cliente = cliente;
    }

    public decimal CalcularPrecoTotal()
    {
        decimal custoProdutos = 0;

        foreach (var produto in produtos)
        {
            custoProdutos += produto.CalcularCustoTotal();
        }

        decimal custoEnvio = cliente.MoraNosEUA() ? 5.0m : 35.0m;

        return custoProdutos + custoEnvio;
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var produto in produtos)
        {
            sb.AppendLine($"Nome: {produto.ObterNome()} | ID: {produto.ObterIdProduto()}");
        }

        return sb.ToString().TrimEnd();
    }

    public string ObterEtiquetaEnvio()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(cliente.ObterNome());
        sb.AppendLine(cliente.ObterEndereco().ObterEnderecoCompleto());

        return sb.ToString().TrimEnd();
    }
}