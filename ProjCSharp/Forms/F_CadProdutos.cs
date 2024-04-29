using SalSystem.Models;
using SalSystem.Services;

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

    private void BtnConfirmar_Click(object sender, EventArgs e)
    {
        string _img = ImagemConverter.ImageToBase64(imgProduto.Image);  
        Produto produto = new(txtNomeProd.Text, txtMarca.Text, txtCategoria.Text, Convert.ToInt32(txtVolume.Text), Convert.ToDouble(txtPreco.Text), txtDescricao.Text,                                                                                          cboPublico.Text, Convert.ToInt32(txtQntInicial.Text), DateTime.Now, _img);
        string _log = produto.CadastraNovoProd();
        if ( _log == "Salvo com sucesso!")
        {
            Utilities.MessageInformation(_log);
        }
        else
            Utilities.MessageError(_log);

    }
}
