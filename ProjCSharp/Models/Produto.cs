using SalSystem.Services;
namespace SalSystem.Models;

internal class Produto(int _idprod, string _nome, string _marca, string _categoria, int _volumeEmMl, double _preco, string _descricao, string _publicoAlvo, int _qntEntradaIni,  DateTime _dataCadastro, string _img)
{
    public int IdProd { get; set; } = _idprod;
    public string Nome { get; set; } = _nome;
    public string Marca { get; set; } = _marca;
    public string Categoria { get; set; } = _categoria;
    public int VolumeEmMl { get; set; } = _volumeEmMl;
    public double Preco { get; set; } = _preco;
    public string Descricao { get; set; } = _descricao;
    public string PublicoAlvo { get; set; } = _publicoAlvo;
    public int QntEntradaInicial { get; set; } = _qntEntradaIni;
    public DateTime DataCadastro { get; set; } = _dataCadastro;
    public string Imagem { get; set; } = _img;

    readonly DataController dataController = new();

    public string CadastraNovoProd()        // Retorna Log derivado da DataController ao front-end//
    {
        return dataController.QuerySetPruduto(Nome, Marca, Categoria, VolumeEmMl, Preco, Descricao, PublicoAlvo, QntEntradaInicial, DataCadastro, Imagem);
    }

    public static List <Produto> GetProduto(string _filtro)  // Retorna o Produto encontrado pela DataController ao front-end//
    {
        DataController dataController = new();
        List <Produto> _produtoEncontrado = dataController.GetProduto(_filtro);
        return _produtoEncontrado;

    }

}
