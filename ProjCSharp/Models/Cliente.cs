using SalSystem.Services;

namespace SalSystem.Models
{
    internal class Cliente(string _nome,string _cpf,string _telefone,string _cep, string _cidade, string _logradouro, string _numeroResidencia)
    {
        public string Nome { get; } = _nome;
        public string CPF { get; } = _cpf;
        public string Telefone { get; } = _telefone;
        public string Cep { get; } = _cep;
        public string Cidade { get; } = _cidade;
        public string Logradouro { get; } = _logradouro;
        public string NumeroResidencia { get; } = _numeroResidencia;

        readonly DataController _DataController = new();        // <--- Instanciando o DataController ---//

        public void CadastrarNovoCliente()
        {
            string _log = _DataController.QueryInsert("INSERT INTO cliente (Nome, CPF, telefone, cidade, logradouro, numero_residencia) " +
            "VALUES " + Nome + ", " + CPF + ", " + Telefone + ", " + Cidade + ", " + Logradouro + ", " + NumeroResidencia + " ");

            MessageBox.Show(_log);
        }

        public void VerificarExistenciaCPF (int _CPF)
        {

        }

    }
}
