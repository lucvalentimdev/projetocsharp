namespace SalSystem.Services;

internal class CPFValidator
{
    public static bool ValidateCPF(string _cpf)
    {
        _cpf = _cpf.Replace(".", "").Replace("-", "");      // Remover caracteres não numéricos do CPF //

        if (_cpf.Length != 11 || !IsDigitsOnly(_cpf))
            return false;
        
        if (AllDigitsSame(_cpf))                           // Verificar se todos os dígitos são iguais (ex: 000.000.000-00) //
            return false;

        //---- Calcular dígitos verificadores ----------------------------//
        int[] multiplier1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplier2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        int sum1 = 0;
        for (int i = 0; i < 9; i++)
        {
            sum1 += (_cpf[i] - '0') * multiplier1[i];
        }

        int digit1 = (sum1 * 10) % 11;
        if (digit1 == 10) digit1 = 0;

        if (digit1 != (_cpf[9] - '0'))
            return false;

        int sum2 = 0;
        for (int i = 0; i < 10; i++)
        {
            sum2 += (_cpf[i] - '0') * multiplier2[i];
        }

        int digit2 = (sum2 * 10) % 11;
        if (digit2 == 10) digit2 = 0;

        return (digit2 == (_cpf[10] - '0'));
    }

    private static bool IsDigitsOnly(string str)
    {
        foreach (char c in str)
        {
            if (c < '0' || c > '9')
                return false;
        }
        return true;
    }

    private static bool AllDigitsSame(string str)
    {
        char firstChar = str[0];
        foreach (char c in str)
        {
            if (c != firstChar)
                return false;
        }
        return true;
    }

}
