using SalSystem.Models;

namespace SalSystem.Forms
{
    public partial class F_Vendas : Form
    {
        public F_Vendas()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = Cliente.GetCliente(txtCPF.Text);
        }
    }
}
