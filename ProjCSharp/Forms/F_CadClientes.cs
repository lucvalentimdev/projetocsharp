using SalSystem.Services;

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
                txtLogradouro.Focus();
            }
            else
                MessageBox.Show("Ocorreu um erro ao consultar o CEP!", "ERRO!");
        }

        private void TxtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.NumbersOnly(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.NumbersOnly(e);
        }
    }
}
