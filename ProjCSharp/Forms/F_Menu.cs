using SalSystem.Forms;
using SalSystem.Views;

namespace SalSystem;

public partial class F_Menu : Form
{
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
        try
        {
            F_Login login = new();              // <--- Obs: Inicia-se a tela de login antes do form principal ---//
            login.ShowDialog();
        }
        catch (Exception)
        {
            Application.Exit();
        }
    }

    private void BtnPagamentos_Click(object sender, EventArgs e)
    {
        F_Vendas f_Vendas = new();
        f_Vendas.ShowDialog();
    }

    private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BtnSair_Click(sender, e);
    }

    private void BtnClientes_Click(object sender, EventArgs e)
    {
        F_CadClientes f_CadClientes = new();
        f_CadClientes.ShowDialog();
    }

    private void F_Menu_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
            Application.Exit();
    }

    private void BtnProdutos_Click(object sender, EventArgs e)
    {
        F_CadProdutos f_CadProdutos = new();
        f_CadProdutos.ShowDialog();
    }
}
