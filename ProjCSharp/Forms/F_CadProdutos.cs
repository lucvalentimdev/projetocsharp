using SalSystem.Models;
using SalSystem.Services;

namespace SalSystem.Forms;

public partial class F_CadProdutos : Form
{
    public F_CadProdutos()
    {
        InitializeComponent();
    }

    private void ColorsController(Color _color)
    {
        //txtNome.BackColor = _color;
        //txtCPF.BackColor = _color;
        // txtTelefone.BackColor = _color;
        // txtLogradouro.BackColor = _color;
        // txtNumeroResid.BackColor = _color;
        // txtCEP.BackColor = _color;
        // rtfObservacao.BackColor = _color;
    }

    private void EnabledController(bool _b)
    {
        // txtNome.Enabled = _b;
        // txtCPF.Enabled = _b;
        // txtTelefone.Enabled = _b;
        // txtLogradouro.Enabled = _b;
        // txtNumeroResid.Enabled = _b;
        // rtfObservacao.Enabled = _b;
        // txtCEP.Enabled = _b;
        BtnConfirmar.Enabled = _b;
        BtnCancelar.Enabled = _b;
    }

    private void ClearScrem()
    {
        /* txtCidade.ReadOnly = true;                  //<--- Tratamentos para campos diferenciados ---//
         txtCidade.BackColor = Color.LightGray;
         cboUF.Enabled = false;
         cboUF.BackColor = Color.LightGray;
         chkNaoInfoCPF.Checked = false;

         txtNome.Text = String.Empty;                //<--- Limpeza de campos comuns do formulário ---//
         txtCPF.Text = String.Empty;
         txtTelefone.Text = String.Empty;
         txtCEP.Text = String.Empty;
         txtCidade.Text = String.Empty;
         txtLogradouro.Text = String.Empty;
         txtNumeroResid.Text = String.Empty;
         cboUF.Text = String.Empty;
         rtfObservacao.Text = String.Empty;

         EnabledController(false);*/
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {

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
        EnabledController(true);
        ColorsController(Color.White);
        BtnAdicionar.Enabled = false;
    }

    private void BtnConfirmar_Click(object sender, EventArgs e)
    {
        string _img = ImagemConverter.ImageToBase64(imgProduto.Image);
        Produto produto = new(txtNomeProd.Text, txtMarca.Text, txtCategoria.Text, Convert.ToInt32(txtVolume.Text), Convert.ToDouble(txtPreco.Text), txtDescricao.Text, cboPublico.Text, Convert.ToInt32(txtQntInicial.Text), DateTime.Now, _img);
        string _log = produto.CadastraNovoProd();
        if (_log == "Salvo com sucesso!")
        {
            Utilities.MessageInformation(_log);
        }
        else
            Utilities.MessageError(_log);
    }

    private void BtnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
