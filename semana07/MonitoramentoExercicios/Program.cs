
using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Atividade> atividades = new List<Atividade>();

        atividades.Add(new Corrida(new DateTime(2022, 11, 3), 30, 4.8));
        atividades.Add(new Ciclismo(new DateTime(2022, 11, 3), 30, 20));
        atividades.Add(new Natacao(new DateTime(2022, 11, 3), 30, 20));

        foreach (Atividade atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}

abstract class Atividade
{
    private DateTime _data;
    private int _duracao;

    public DateTime Data
    {
        get { return _data; }
    }

    public int Duracao
    {
        get { return _duracao; }
    }

    public Atividade(DateTime data, int duracao)
    {
        _data = data;
        _duracao = duracao;
    }

    public abstract double ObterDistancia();
    public abstract double ObterVelocidade();
    public abstract double ObterRitmo();

    public string ObterResumo()
    {
        string data = Data.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);

        return $"{data} {GetType().Name} ({Duracao} min) - Distância: {ObterDistancia():0.##} km, Velocidade: {ObterVelocidade():0.##} km/h, Ritmo: {ObterRitmo():0.##} min por km";
    }
}

class Corrida : Atividade
{
    private double _distancia;

    public Corrida(DateTime data, int duracao, double distancia)
        : base(data, duracao)
    {
        _distancia = distancia;
    }

    public override double ObterDistancia()
    {
        return _distancia;
    }

    public override double ObterVelocidade()
    {
        return (_distancia / Duracao) * 60;
    }

    public override double ObterRitmo()
    {
        return (double)Duracao / _distancia;
    }
}

class Ciclismo : Atividade
{
    private double _velocidade;

    public Ciclismo(DateTime data, int duracao, double velocidade)
        : base(data, duracao)
    {
        _velocidade = velocidade;
    }

    public override double ObterDistancia()
    {
        return (_velocidade * Duracao) / 60;
    }

    public override double ObterVelocidade()
    {
        return _velocidade;
    }

    public override double ObterRitmo()
    {
        return 60 / _velocidade;
    }
}

class Natacao : Atividade
{
    private int _voltas;

    public Natacao(DateTime data, int duracao, int voltas)
        : base(data, duracao)
    {
        _voltas = voltas;
    }

    public override double ObterDistancia()
    {
        return (_voltas * 50.0) / 1000;
    }

    public override double ObterVelocidade()
    {
        return (ObterDistancia() / Duracao) * 60;
    }

    public override double ObterRitmo()
    {
        return Duracao / ObterDistancia();
    }
}

