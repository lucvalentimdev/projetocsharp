namespace SalSystem.Views
{
    public partial class F_Login : Form
    {
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
            fechaLogin = true;
            Close();
        }
    }
}
