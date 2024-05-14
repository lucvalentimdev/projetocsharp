using SalSystem.Services.DataAcess;
namespace SalSystem.Forms;

public partial class F_Caixa : Form
{
    readonly DataController controller = new();

    public F_Caixa()
    {
        InitializeComponent();
    }

    private void BtnConsultar_Click(object sender, EventArgs e)
    {
        gridCaixa.DataSource = DataTableAssistant.ProcessData(controller.GetInfoCaixa());
    }
}
