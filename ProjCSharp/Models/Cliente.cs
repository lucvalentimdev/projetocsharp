namespace SalSystem.Models
{
    internal class Cliente(string _nome, int _cpf, int _telefone, int _cep, string _cidade, string _logradouro, int _numeroResidencia)
    {
        public string Nome { get; set; } = _nome;
        public int CPF { get; set; } = _cpf;
        public int Telefone { get; set; } = _telefone;
        public int Cep { get; set; }= _cep;
        public string Cidade { get; set; } = _cidade;
        public string Logradouro { get; set; } = _logradouro;
        public int NumeroResidencia { get; set; } = _numeroResidencia;


        public Boolean CadastrarNovoCliente()
        {

            return true;
        }

    }
}
