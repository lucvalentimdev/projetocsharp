namespace SalSystem.Models;

internal class Produto(string _nome, string _marca, string _categoria, int _volumeEmMl, decimal _preco, string _descricao, string _publicoAlvo, int _quantEntrada, DateTime _dataLancamento)
{
    public string Nome { get; set; } = _nome;
    public string Marca { get; set; } = _marca;
    public string Categoria { get; set; } = _categoria;
    public int VolumeEmMl { get; set; } = _volumeEmMl;
    public decimal Preco { get; set; } = _preco;
    public string Descricao { get; set; } = _descricao;
    public string PublicoAlvo { get; set; } = _publicoAlvo;
    public int QuantEntrada { get; set; } = _quantEntrada;
    public DateTime DataLancamento { get; set; } = _dataLancamento;


    public bool CadastraNovoProd()
    {
        if (2 > 1)
            return true;
        else
            return false;

    }

}
