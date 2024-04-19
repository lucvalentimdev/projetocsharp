using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using SalSystem.Models;
using SalSystem.Services;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

namespace SalSystem.Views
{
    public partial class F_CadClientes : Form
    {
        public F_CadClientes()
        {
            InitializeComponent();
        }

        private void ColorsController(Color _color)
        {
            txtNome.BackColor = _color;
            txtCPF.BackColor = _color;
            txtTelefone.BackColor = _color;
            txtLogradouro.BackColor = _color;
            txtNumeroResid.BackColor = _color;
            txtCEP.BackColor = _color;
            rtfObservacao.BackColor = _color;
        }

        private void EnabledController(bool _b)
        {
            txtNome.Enabled = _b;
            txtCPF.Enabled = _b;
            txtTelefone.Enabled = _b;
            txtLogradouro.Enabled = _b;
            txtNumeroResid.Enabled = _b;
            rtfObservacao.Enabled = _b;
            txtCEP.Enabled = _b;
            BtnConfirmar.Enabled = _b;
            BtnCancelar.Enabled = _b;
        }

        private void ClearScrem()
        {
            txtCidade.ReadOnly = true;                  //<--- Tratamentos para campos diferenciados ---//
            txtCidade.BackColor = Color.LightGray;
            cboUF.Enabled = false;
            cboUF.BackColor = Color.LightGray;
            chkNaoInfoCPF.Checked = false;

            txtNome.Text = String.Empty;                //<--- Limpeza de campos comuns do formulário ---//
            txtCPF.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCEP.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtNumeroResid.Text = String.Empty;
            cboUF.Text = String.Empty;
            rtfObservacao.Text = String.Empty;

            EnabledController(false);
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCPF.Text) || string.IsNullOrWhiteSpace(txtCEP.Text) ||
                string.IsNullOrWhiteSpace(txtLogradouro.Text) || string.IsNullOrWhiteSpace(txtNumeroResid.Text))

                return false;               // <--- Se pelo menos um campo está vazio ou contém apenas espaços em branco //
            else
                return true;                // <--- Todos os campos estão preenchidos corretamente //

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ClearScrem();
            EnabledController(false);
            ColorsController(Color.LightGray);
            BtnAdicionar.Enabled = true;
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.NumbersOnly(e);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.NumbersOnly(e);
        }

        private void txtNumeroResid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            _ = GetCEP(txtCEP.Text);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            EnabledController(true);
            ColorsController(Color.White);
            BtnAdicionar.Enabled = false;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.NumbersOnly(e);
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                Cliente _cliente = new(txtNome.Text, txtCPF.Text, txtTelefone.Text, txtCEP.Text, cboUF.Text, txtCidade.Text, txtLogradouro.Text, txtNumeroResid.Text);
                string _log = _cliente.CadastrarNovoCliente();


                if (_log == "Salvo com sucesso!")
                {
                    Utilities.MessageInformation(_log);

                    BtnCancelar_Click(sender, e);
                }
                else
                    Utilities.MessageError(_log);
            }
            else
                Utilities.MessageCaution("Existem campos obrigatórios não preenchidos!");
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            Cliente.ValidaCPF(txtCPF.Text);
        }
    }
}
