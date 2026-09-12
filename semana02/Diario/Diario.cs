using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public Diario()
    {
    }

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter output = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                output.WriteLine($"{registro._data}|{registro._textoPergunta}|{registro._textoResposta}");
            }
        }
    }

    public void CarregarDoArquivo(string arquivo)
    {
        if (File.Exists(arquivo))
        {
            _registros.Clear();
            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split("|");

                if (partes.Length == 3)
                {
                    string data = partes[0];
                    string pergunta = partes[1];
                    string resposta = partes[2];

                    Registro registro = new Registro(data, pergunta, resposta);
                    _registros.Add(registro);
                }
            }
        }
    }
}