using SalSystem.Models;

namespace SalSystem.Forms;

public partial class F_CadProdutos : Form
{
    public F_CadProdutos()
    {
        InitializeComponent();
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BtnUploadImg_Click(object sender, EventArgs e)
    {
        string _caminho;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _caminho = openFileDialog.FileName;
            imgProduto.ImageLocation = _caminho;
        }
    }

    private void BtnRemoverImg_Click(object sender, EventArgs e)
    {
        imgProduto.Image = null;
        imgProduto.Image = Properties.Resources.not_img_128x128;
    }

    private void BtnConfirmar_Click(object sender, EventArgs e)
    {
        Produto produto = new(txtNomeProd.Text, txtMarca.Text, txtCategoria.Text, Convert.ToInt32(txtVolume.Text), Convert.ToDouble(txtPreco.Text), txtDescricao.Text, cboPublico.Text, Convert.ToInt32(txtQntInicial.Text), DateTime.Now);
        produto.CadastraNovoProd();

    }
}
