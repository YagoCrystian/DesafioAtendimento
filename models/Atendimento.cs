namespace Autoglass.models;
public class Atendimento
{
    //?? ATRIBUTOS DA CLASSE
    public string CodigoAtendimento { get; protected set; }
    public DateTime DataAbertura { get; protected set; }
    public string Seguradora { get; protected set; }
    public string ItemDanificado { get; protected set; }
    public double ValorDeFranquia { get; protected set; }
    public string NomeDoSegurado { get; protected set; }
    public string NomeAtendente { get; protected set; }
    public string Cidade { get; protected set; }
    public string Estado { get; protected set; }
    public string NumeroDaApolice { get; protected set; }
    public string NomeDoVeiculo { get; protected set; }

    //??METODOS DA CLASSE
    public Atendimento(
    string codigoAtendimento,
    DateTime dataAbertura,
    string seguradora,
    string itemDanificado,
    double valorDeFranquia,
    string nomeDoSegurado,
    string nomeAtendente,
    string cidade,
    string estado,
    string numeroDaApolice,
    string nomeDoVeiculo)
    {
        SetCodigoAtendimento(codigoAtendimento);
        SetDataAbertura(dataAbertura);
        SetSeguradora(seguradora);
        SetItemDanificado(itemDanificado);
        SetValorDeFranquia(valorDeFranquia);
        SetNomeDoSegurado(nomeDoSegurado);
        SetNomeAtendente(nomeAtendente);
        SetCidade(cidade);
        SetEstado(estado);
        SetNumeroDaApolice(numeroDaApolice);
        SetNomeDoVeiculo(nomeDoVeiculo);
    }

    public void SetCodigoAtendimento(string codigoAtendimento)
    {
        if (string.IsNullOrWhiteSpace(nameof(codigoAtendimento)))
        {
            throw new ArgumentNullException($"O codigo de atendimento nao pode ser vazio!");
        }
        CodigoAtendimento = codigoAtendimento;
    }
    public void SetDataAbertura(DateTime dataAbertura)
    {
        if (DataAbertura.Year <= 0)
        {
            throw new ArgumentException($"A data de abertura do atendimento nao pode ser vazia ou menor que a data minima!");
        }
        DataAbertura = dataAbertura;
    }
    public void SetSeguradora(string seguradora)
    {
        if (string.IsNullOrWhiteSpace(nameof(seguradora)))
        {
            throw new ArgumentNullException($"A seguradora nao pode ser vazia!");
        }
        Seguradora = seguradora;
    }
    public void SetItemDanificado(string itemDanificado)
    {
        if (string.IsNullOrWhiteSpace(nameof(itemDanificado)))
        {
            throw new ArgumentNullException($"O item danificado nao pode ser vazio!");
        }
        ItemDanificado = itemDanificado;
    }
    public void SetValorDeFranquia(double valorDeFranquia)
    {
        if (valorDeFranquia <= 0)
        {
            throw new ArgumentException($"O valor de franquia nao pode ser zero ou negativo!");
        }
        ValorDeFranquia = valorDeFranquia;
    }
    public void SetNomeDoSegurado(string nomeDoSegurado)
    {
        if (string.IsNullOrWhiteSpace(nameof(nomeDoSegurado)))
        {
            throw new ArgumentNullException($"O nome do segurado nao pode ser vazio!");
        }
        NomeDoSegurado = nomeDoSegurado;
    }
    public void SetNomeAtendente(string nomeAtendente)
    {
        if (string.IsNullOrWhiteSpace(nameof(nomeAtendente)))
        {
            throw new ArgumentNullException($"O nome do atendente nao pode ser vazio!");
        }
        NomeAtendente = nomeAtendente;
    }
    public void SetCidade(string cidade)
    {
        if (string.IsNullOrWhiteSpace(nameof(cidade)))
        {
            throw new ArgumentNullException($"A cidade nao pode ser vazia!");
        }
        Cidade = cidade;
    }
    public void SetEstado(string estado)
    {
        if (string.IsNullOrWhiteSpace(nameof(estado)))
        {
            throw new ArgumentNullException($"O estado nao pode ser vazio!");
        }
        Estado = estado;
    }
    public void SetNumeroDaApolice(string numeroDaApolice)
    {
        if (string.IsNullOrWhiteSpace(nameof(numeroDaApolice)))
        {
            throw new ArgumentNullException($"O numero da apolice nao pode ser vazio!");
        }
        NumeroDaApolice = numeroDaApolice;
    }
    public void SetNomeDoVeiculo(string nomeDoVeiculo)
    {
        if (string.IsNullOrWhiteSpace(nameof(nomeDoVeiculo)))
        {
            throw new ArgumentNullException($"O nome do veiculo nao pode ser vazio!");
        }
        NomeDoVeiculo = nomeDoVeiculo;
    }

}