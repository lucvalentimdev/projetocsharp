namespace SalSystem.Models;

internal class Venda(int _idCliente, string _nomeprod, int _idProdVenda, int _quantidade, double _preco)
{
    public int Id { get; set; } = _idCliente;
    public string NomeProd { get; set; } = _nomeprod;
    public int IdProdVenda { get; set; } = _idProdVenda;
    public int Quantidade { get; set; } = _quantidade;
    public double Preco { get; set; } = _preco;
    
    // var //
    private static double totais;
    

    public double CalcularItemVenda()
    {
        return Quantidade * Preco;
    }

    public List<string> ExibirDetalhes()
    {
        double _subtotal = CalcularItemVenda();
        totais += _subtotal;
        
        List<string> _list = [ "Cód: "+IdProdVenda.ToString()+ " Prod.: "+NomeProd.ToString()+ " Qnt.: "+Quantidade.ToString()+" Vl.Unt.: "+Preco.ToString()+" SubTotal: " +_subtotal.ToString()+"\r\n"];

        return _list;
    }

    public static double ExibirValorTotal()
    {
        return totais;
    }

}
