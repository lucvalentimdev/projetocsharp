using SalSystem.Models;
using SalSystem.Services;
using System.Runtime.CompilerServices;

namespace SalSystem.Forms;

public partial class F_Vendas : Form
{
    public F_Vendas()
    {
        InitializeComponent();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        rtPedido.Clear();
        cboFormaReceb.Text = "";
        txtValorTotal.Text = string.Empty;
        txtQntItens.Text = string.Empty;
        btnLimparClie_Click(sender, e);
        btnLimpar_Click(sender, e);
        Close();
    }

    private void btnConsultaCliente_Click(object sender, EventArgs e)
    {
        txtNomeCliente.Text = Cliente.EncontrarNomeCliente(txtCPF.Text);
    }

    private void btnConsultaProd_Click(object sender, EventArgs e)
    {
        if (txtConsultaProd.Text == "")
            return;

        List<Produto> _produtos = new(Produto.GetProduto(txtConsultaProd.Text));

        if (_produtos == null)
        {
            Utilities.MessageInformation("Nenhum _produto encontrado!");
            return;
        }
        else
        {
            foreach (Produto _produto in _produtos)                              // Acessa o objeto _produto e dentro do laço carrega os dados //
            {
                txtCodProd.Text = _produto.IdProd.ToString();
                txtNomeProd.Text = _produto.Nome.ToString();
                txtDescricaoProd.Text = _produto.Descricao.ToString();
                txtValorUnitario.Text = _produto.Preco.ToString();
                if (_produto.Imagem.ToString() != null && _produto.Imagem.ToString() != string.Empty)
                    imgProduto.Image = ImagemConverter.Base64ToImage(_produto.Imagem.ToString());
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

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        txtCodProd.Text = string.Empty;
        txtNomeProd.Text = string.Empty;
        txtDescricaoProd.Text = string.Empty;
        txtValorUnitario.Text = string.Empty;
        txtConsultaProd.Text = string.Empty;
    }

    private void btnAddProd_Click(object sender, EventArgs e)
    {
        Venda venda = new(0, txtNomeProd.Text, Convert.ToInt32(txtCodProd.Text), 1, Convert.ToDouble(txtValorUnitario.Text));
        
        List<string> _vendasConteudo = new(venda.ExibirDetalhes());             //<-- Ao adicionar um produto a Venda, exibe os detalhes da venda //
        foreach (string _itens in _vendasConteudo)
        {
            rtPedido.AppendText(_itens);
        }
    }

}
