using SalSystem.Services;

namespace SalSystem.Models
{
    internal class Cliente(string _nome, int _cpf, int _telefone, int _cep, string _cidade, string _logradouro, int _numeroResidencia)
    {
        public string Nome { get; } = _nome;
        public int CPF { get; } = _cpf;
        public int Telefone { get; } = _telefone;
        public int Cep { get; } = _cep;
        public string Cidade { get; } = _cidade;
        public string Logradouro { get; } = _logradouro;
        public int NumeroResidencia { get; } = _numeroResidencia;

        DataController _DataController = new();

        public Boolean CadastrarNovoCliente()
        {

            return true;
        }


        public Boolean VerificarExistenciaCPF (int _CPF)
        {



            return true;
        }

    }
}
