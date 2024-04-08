namespace SalSystem.Services
{
    internal class Utilities
    {
        
        public static void NumbersOnly(KeyPressEventArgs e)  // Igonara teclas que não forem número //Como parametro recebe (e) do evento KeyPress // 
        {                                                         
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;              
            }
        }
    }
}
