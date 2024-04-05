using SalSystem.Controllers;

namespace SalSystem.Views
{
    public partial class F_Login : Form
    {
        private readonly string _stringConnect = "server=localhost;user=root;pwd=;database=test;";
        private bool fechaLogin = false;

        public F_Login()
        {
            InitializeComponent();
        }

        private void F_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fechaLogin)
                Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ExecutaLogin();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            TestConnect testConnect = new(_stringConnect);

            if (testConnect.ConnectTest())
                lbStatusConn.Text = "Status: Conectado!";
            else
                lbStatusConn.Text = "Status: Desconectado! [Erro]";
        }

        private void F_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecutaLogin();
        }

        private void ExecutaLogin()         // Procedure para tratar o login do usuário //
        {
            ProcessaLogin login = new(_stringConnect);
            if (login.ValidaLogin(txtUsuario.Text, txtSenha.Text))
            {
                fechaLogin = true;
                Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado ou senha incorreta!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtUsuario.Focus();
            }
        }

        private void F_Login_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
