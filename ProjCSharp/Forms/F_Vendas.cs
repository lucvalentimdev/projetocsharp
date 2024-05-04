using SalSystem.Models;
using SalSystem.Services;

namespace SalSystem.Forms;

public partial class F_Vendas : Form
{
    public F_Vendas()
    {
        InitializeComponent();
    }


    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnConsultaCliente_Click(object sender, EventArgs e)
    {
        txtNomeCliente.Text = Cliente.EncontrarNomeCliente(txtCPF.Text);
    }

    private void btnConsultaProd_Click(object sender, EventArgs e)
    {
        List<Produto> _produtos = new(Produto.GetProduto(txtConsultaProd.Text));

        if (_produtos == null)
            Utilities.MessageInformation("Nenhum produto encontrado!");
        else
        {
            foreach (Produto produto in _produtos)                              // Acessa o objeto produto e dentro do laço carrega os dados //
            {
                txtCodProd.Text = produto.IdProd.ToString();
                txtNomeProd.Text = produto.Nome.ToString();
                txtDescricaoProd.Text = produto.Descricao.ToString();
                txtValorUnitario.Text = produto.Preco.ToString();
                if (produto.Imagem.ToString() != null && produto.Imagem.ToString() != string.Empty)
                    imgProduto.Image = ImagemConverter.Base64ToImage(produto.Imagem.ToString());
                else
                    imgProduto.Image = Properties.Resources.not_img_128x128;
            }
        }
    }

    private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
    {
        Utilities.NumbersOnly(e);
    }

    private void btnLimparClie_Click(object sender, EventArgs e)
    {
        txtNomeCliente.Text = string.Empty;
        txtCPF.Text = string.Empty;
    }
}
