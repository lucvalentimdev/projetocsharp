namespace SalSystem.Models;

internal class Produto(string _nome, string _marca, string _categoria, int _volumeEmMl, double _preco, string _descricao, string _publicoAlvo, int _qntEntradaIni,  DateTime _dataCadastro) //byte[] _img,
{
    public string Nome { get; set; } = _nome;
    public string Marca { get; set; } = _marca;
    public string Categoria { get; set; } = _categoria;
    public int VolumeEmMl { get; set; } = _volumeEmMl;
    public double Preco { get; set; } = _preco;
    public string Descricao { get; set; } = _descricao;
    public string PublicoAlvo { get; set; } = _publicoAlvo;
    public int QntEntradaInicial { get; set; } = _qntEntradaIni;
    public DateTime DataCadastro { get; set; } = _dataCadastro;
    //public byte[] Imagem { get; set; }

    public bool CadastraNovoProd()
    {
        if (2 > 1)
            return true;
        else
            return false;

    }

}
