namespace SalSystem.Models;

internal class CaixaFinanceiro(decimal _saldo)
{
    public decimal Saldo { get; private set; } = _saldo;
    
    public void AdicionarDinheiro(decimal valor) // Método para adicionar dinheiro ao caixa//
    {
        if (valor <= 0)
        {
            
        }

        Saldo += valor;
    }
    
    public void RetirarDinheiro(decimal valor) // Método para retirar dinheiro do caixa //
    {
        if (valor <= 0)
        {
            
        }

        if (valor > Saldo)
        {
           
        }

        Saldo -= valor;
       
    }



}
