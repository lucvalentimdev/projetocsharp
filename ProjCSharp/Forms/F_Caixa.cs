using MySql.Data.MySqlClient;
using SalSystem.Services.DataAcess;

namespace SalSystem.Forms;

public partial class F_Caixa : Form
{
    readonly DataController dataController = new();

    public F_Caixa()
    {
        InitializeComponent();
    }

    private void BtnConsultar_Click(object sender, EventArgs e)
    {
        gridCaixa.DataSource = DataTableAssistant.ProcessData(dataController.GetInfoCaixa());
    }

    private void BtnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
