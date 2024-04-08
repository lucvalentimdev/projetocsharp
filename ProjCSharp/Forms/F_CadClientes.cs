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

        private void BtnEdtEndereco_Click(object sender, EventArgs e)
        {
            txtCidade.ReadOnly = false;
            txtCidade.BackColor = Color.White;
            cboUF.Enabled = true;
            cboUF.BackColor = Color.White;
        }

        private void ClearScrem()
        {
            // Tratamentos diferenciados //
            txtCidade.ReadOnly = true;
            txtCidade.BackColor = Color.LightGray;
            cboUF.Enabled = false;
            cboUF.BackColor = Color.LightGray;
            chkNaoInfoCPF.Checked = false;

            // Limpeza de campos //
            txtNome.Text = String.Empty;
            txtCPF.Text = String.Empty; 
            txtTelefone.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtNumeroResid.Text = String.Empty;
            cboUF.Text = String.Empty;
            rtfObservacao.Text = String.Empty;
    
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ClearScrem();
        }
    }
}
