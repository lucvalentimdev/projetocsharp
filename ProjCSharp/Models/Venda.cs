namespace SalSystem.Models;

internal class Venda(int _idCliente, string _nomeprod, int _idProdVenda, int _quantidade, double _preco)
{
    public int Id { get; set; } = _idCliente;
    public string NomeProd { get; set; } = _nomeprod;
    public int IdProdVenda { get; set; } = _idProdVenda;
    public int Quantidade { get; set; } = _quantidade;
    public double Preco { get; set; } = _preco;

    // var //
    public static double totais;
    public static double subtotais;

    public double CalcularItemVenda()
    {
        return Quantidade * Preco;
    }

    public static double CalcularTotalFinal(double _valorTotalItens, double _percentualDesconto)
    {
        double _desconto = _valorTotalItens * (_percentualDesconto / 100);
        double _precoFinal = _valorTotalItens - _desconto;

        return _precoFinal;
    }

    public double CalcularSubTotal()
    {
        subtotais = CalcularItemVenda();
        totais += subtotais;

        return subtotais;
       
    }

    public Boolean SalvarVenda(List <Produto> _produtosVendidos)
    {

        return true;
    } 


}
