using SalSystem.Services;

namespace SalSystem.Models;

internal class Cliente(string _nome, string _cpf, string _telefone, string _cep, string _uf, string _cidade, string _logradouro, string _numeroResidencia)
{
    public string Nome { get; } = _nome;
    public string CPF { get; } = _cpf;
    public string Telefone { get; } = _telefone;
    public string Cep { get; } = _cep;
    public string Cidade { get; } = _cidade;
    public string Uf { get; } = _uf;
    public string Logradouro { get; } = _logradouro;
    public string NumeroResidencia { get; } = _numeroResidencia;

    readonly DataController dataController = new();        // <--- Instanciando o DataController ---//

    public string CadastrarNovoCliente()
    {
        return dataController.QryInsertCliente( Nome,  CPF, Telefone,  Cidade, Cep, Uf, Logradouro, NumeroResidencia);
    }

    public static void ValidaCPF (string _CPF)
    {
        if (!CPFValidator.ValidateCPF(_CPF))
            Utilities.MessageCaution("Atenção: CPF Inválido, cuidado ao salvar!");
    }

    public static string EncontrarNomeCliente(string _cpf)
    {
        DataController dataController = new();
        return dataController.GetClienteNome(_cpf);
    }



}
