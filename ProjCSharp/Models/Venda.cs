using SalSystem.Services;

namespace SalSystem.Models;

internal class Venda (int _idCliente, double _valorItens, double _valorDescontos, double _valorTotal, int _idColaborador, string _tipoPagto)
{
    public int IdCliente { get; set; } = _idCliente;
    public double ValorItens { get; set;} = _valorItens;
    public double ValorDescontos { get; set; } = _valorDescontos;
    public double ValorTotal { get; set;} = _valorTotal;
    public int IdColaborador { get; set; } = _idColaborador;
    public string TipoPagto { get; set; } = _tipoPagto;

    //var//
    readonly DataController dataController = new();



    public string SalvarVenda()
    {
        string _log = dataController.QuerySetVenda(IdCliente, ValorItens, ValorDescontos, ValorTotal, IdColaborador, TipoPagto);
        return _log;
    }




}
