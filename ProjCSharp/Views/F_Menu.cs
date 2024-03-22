using ProjCSharp.Models;

namespace ProjCSharp
{
    public partial class F_Menu : Form
    {
        readonly Connect Connect = new ("server=localhost ;user=root ; pwd=;database=test ;Connect Timeout=28800;Command Timeout=2880");

        public F_Menu()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            bool StartedConection = Connect.OpenConnection();

            if (StartedConection)
                MessageBox.Show("Bem vindo ao sistema de vendas. Conexão bem estabelecida");
            else
                MessageBox.Show("Erro ao conectar ao banco de dados!");
        }
    }
}
