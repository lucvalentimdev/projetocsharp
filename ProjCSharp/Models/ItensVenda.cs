using SalSystem.Services.DataAcess;

namespace SalSystem.Models;

internal class ItensVenda( string _nomeprod, int _idProdVenda, int _quantidade, double _preco)
{
    public string NomeProd { get; set; } = _nomeprod;
    public int IdProdVenda { get; set; } = _idProdVenda;
    public int Quantidade { get; set; } = _quantidade;
    public double Preco { get; set; } = _preco;

    // var //
    public static double totaisItens;
    public static double subtotais;
    readonly DataController dataController = new();


    public double CalcularItensVenda()              //--- Calculo dos itens da venda = Subtotal ---//
    {
        return Quantidade * Preco;
    }

    public void CalcSubTotal_Itens()                //--- Calculo do subtotal  ---//
    {
        totaisItens += CalcularItensVenda();
    }

    public static double CalcTotalItensFinal(double _valorTotalItens, double _percentualDesconto)  //--- Calculo do valor a receber final ---//
    {
        double _desconto = _valorTotalItens * (_percentualDesconto / 100);
        double _precoFinal = _valorTotalItens - _desconto;

        return _precoFinal;
    }



}
