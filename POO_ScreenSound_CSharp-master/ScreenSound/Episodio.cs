﻿class episodio
{

    private List<string> convidados = new();
    public episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get;}
    public string Titulo { get;}
    public int Duracao { get;}
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(String convidado)
    {
        convidados.Add(convidado);
    }
}