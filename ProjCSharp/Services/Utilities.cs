namespace SalSystem.Services;

internal class Utilities
{//----------------------------------------------------------------------------------------------------------------------------------------------------------//
// Igonara teclas que não forem número // ** Como parametro recebe (e) do evento KeyPress **  ---------------------------------------------------------------// 
    public static void NumbersOnly(KeyPressEventArgs e)                                 // Chamar esse metodo no evento: KeyPress do TxtBox ----------------//
    {                                                         
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;              
        }
    }
//---------------------------------------------------------------------------------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------------------------------------------------------------------------------//
// Metodos de Mensagens de exibição persolanizadas --------------------------------------------------------------------------------------------------------//
    public static void MessageError(string _text)       // Mensagem de Erro //
    {
        MessageBox.Show(_text, "SalSystem - Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void MessageCaution(string _text)     // Mensagem de Aviso //
    {
        MessageBox.Show(_text, "SalSystem - Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void MessageInformation(string _text)  // Mensagem Informativa //
    {
        MessageBox.Show(_text, "SalSystem informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
//----------------------------------------------------------------------------------------------------------------------------------------------------------//
}
