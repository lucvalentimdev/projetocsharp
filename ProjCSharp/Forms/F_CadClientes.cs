using System.Runtime.ConstrainedExecution;

namespace SalSystem.Views
{
    public partial class F_CadClientes : Form
    {
        public F_CadClientes()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            _ = GetCEP(TxtCEP.Text);
        }

        private async Task GetCEP(string _cep)
        {
            using var cepService = new CepService();
            var (City, State) = await cepService.GetCityAndStateByCepAsync(_cep);

            if (!string.IsNullOrEmpty(City))
            {
                txtCidade.Text = City;
                cboUF.Text = State;
            }
            else
                MessageBox.Show("Ocorreu um erro ao consultar o CEP!", "ERRO!");
        }

        private void TxtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;               // Ignora a tecla pressionada se não for um número //
            }
        }
    }
}
