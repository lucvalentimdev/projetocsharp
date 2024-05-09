using SalSystem.Services;

namespace SalSystem.Models;

internal class Venda (int _idCliente, double _valorItens, double _valorDescontos, double _valorTotal, int _idColaborador)
{
    public int IdCliente { get; set; } = _idCliente;
    public double ValorItens { get; set;} = _valorItens;
    public double ValorDescontos { get; set; } = _valorDescontos;
    public double ValorTotal { get; set;} = _valorTotal;
    public int IdColaborador { get; set; } = _idColaborador;

    //var//
    DataController dataController = new();



    public string SalvarVenda()
    {
        string _log = dataController.QuerySetVenda(IdCliente, ValorItens, ValorDescontos, ValorTotal, IdColaborador);
        return _log;
    }




}
