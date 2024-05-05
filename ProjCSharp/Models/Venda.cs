using SalSystem.Forms;

namespace SalSystem.Models;

internal class Venda(int _id, string _nomeprod, int _idProdVenda, int _quantidade, double _preco)
{
    public int Id { get; set; } = _id;
    public string NomeProd { get; set; } = _nomeprod;
    public int IdProdVenda { get; set; } = _idProdVenda;
    public int Quantidade { get; set; } = _quantidade;
    public double Preco { get; set; } = _preco;

    public double CalcularItemVenda()
    {
        return Quantidade * Preco;
    }

    public List<string> ExibirDetalhes()
    {
        double _subtotal = CalcularItemVenda();
        
        List<string> _list = [ "Id.Prod: "+IdProdVenda.ToString()+ " Produto: "+NomeProd.ToString()+ " Qnt.: "+Quantidade.ToString()+" Vl.Unt.: "+Preco.ToString()+" SubTotal: " +_subtotal.ToString() ];
        
        return _list;
    }

}
