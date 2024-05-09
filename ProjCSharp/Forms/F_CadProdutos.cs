using SalSystem.Models;
using SalSystem.Services;

namespace SalSystem.Forms;

public partial class F_CadProdutos : Form
{
    public F_CadProdutos()
    {
        InitializeComponent();
    }

    readonly DataController dataController = new();

    private void ColorsController(Color _color)
    {
        txtNomeProd.BackColor = _color;
        txtMarca.BackColor = _color;
        cboPublico.BackColor = _color;
        txtCategoria.BackColor = _color;
        txtVolume.BackColor = _color;
        txtDescricao.BackColor = _color;
        txtPreco.BackColor = _color;
        txtQntInicial.BackColor = _color;
    }

    private void EnabledController(bool _b)
    {
        txtNomeProd.Enabled = _b;
        txtMarca.Enabled = _b;
        cboPublico.Enabled = _b;
        txtCategoria.Enabled = _b;
        txtVolume.Enabled = _b;
        txtDescricao.Enabled = _b;
        txtPreco.Enabled = _b;
        txtQntInicial.Enabled = _b;
        BtnConfirmar.Enabled = _b;
        BtnCancelar.Enabled = _b;
        BtnRemoverImg.Enabled = _b;
        BtnUploadImg.Enabled = _b;
    }

    private void ClearScrem()
    {
        txtNomeProd.Text = string.Empty;                //<--- Limpeza de campos comuns do formulário ---//
        txtMarca.Text = string.Empty;
        cboPublico.Text = string.Empty;
        txtCategoria.Text = string.Empty;
        txtVolume.Text = string.Empty;
        txtDescricao.Text = string.Empty;
        txtPreco.Text = string.Empty;
        txtQntInicial.Text = string.Empty;
        txtIDProd.Text = string.Empty;


        EnabledController(false);
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        ClearScrem();
        BtnAdicionar.Enabled = true;
        BtnConsultar.Enabled = true;
        BtnRemoverImg_Click(sender, e);
        ColorsController(Color.LightGray);
    }

    private void BtnUploadImg_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string _caminho = openFileDialog.FileName;
            imgProduto.ImageLocation = _caminho;
        }
    }

    private void BtnRemoverImg_Click(object sender, EventArgs e)
    {
        imgProduto.Image = null;
        imgProduto.Image = Properties.Resources.not_img_128x128;
    }
    private void BtnAdicionar_Click(object sender, EventArgs e)
    {
        txtIDProd.Text = dataController.QueryGetIDProd();

        EnabledController(true);
        ColorsController(Color.White);
        BtnConsultar.Enabled = false;
        BtnAdicionar.Enabled = false;
    }

    private void BtnConfirmar_Click(object sender, EventArgs e)
    {
        string _img = ImagemConverter.ImageToBase64(imgProduto.Image);

        Produto produto = new(Convert.ToInt32(txtIDProd.Text), txtNomeProd.Text, txtMarca.Text, txtCategoria.Text, Convert.ToInt32(txtVolume.Text), Convert.ToDouble(txtPreco.Text), txtDescricao.Text, cboPublico.Text, Convert.ToInt32(txtQntInicial.Text), DateTime.Now, _img);
       
        string _log = produto.CadastraNovoProd();
        if (_log == "Salvo com sucesso!")
        {
            Utilities.MessageInformation(_log);
            BtnCancelar_Click(sender, e);
        }
        else
            Utilities.MessageError(_log);
    }

    private void BtnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void F_CadProdutos_Load(object sender, EventArgs e)
    {
       
    }
}
