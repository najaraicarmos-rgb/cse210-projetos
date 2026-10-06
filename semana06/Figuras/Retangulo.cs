public class Retangulo : Figura
{
    private double _comprimento;
    private double _largura;

    public Retangulo(string cor, double comprimento, double largura) : base(cor)
    {
        _comprimento = comprimento;
        _largura = largura;
    }

    public override double ObterArea()
    {
        return _comprimento * _largura;
    }
}