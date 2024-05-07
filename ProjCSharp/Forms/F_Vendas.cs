using SalSystem.Models;
using SalSystem.Services;

namespace SalSystem.Forms;

public partial class F_Vendas : Form
{
    public F_Vendas()
    {
        InitializeComponent();
    }

    // Var //
    List<Venda>? listaVendas;

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

        List<Produto> _produtos = Produto.GetProduto(txtConsultaProd.Text);

        if (_produtos == null)
        {
            Utilities.MessageInformation("Nenhum _produto encontrado!");
            return;
        }
        else
        {
            foreach (Produto _produto in _produtos)                              // Acessa o objeto _produtos e dentro do laço carrega os dados para EXIBIÇÃO //
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

            txtQntProd.Text = "1";
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
        txtQntProd.Text = string.Empty;
    }

    private void btnAddProd_Click(object sender, EventArgs e)
    {
        Venda venda = new(0, txtNomeProd.Text, Convert.ToInt32(txtCodProd.Text), Convert.ToInt32(txtQntProd.Text), Convert.ToDouble(txtValorUnitario.Text));
        listaVendas.Add(venda);                                                             //<-- Alimenta a lista de vendas com a Venda pré concluída //

        List<string> _vendasDetalhes = new(venda.ExibirDetalhes());                         //<-- Após add um prod a uma Venda, EXIBE OS DETALHES populando o RichText  //
        foreach (string _itens in _vendasDetalhes)
        {
            rtPedido.AppendText(_itens);
        }

        txtValorTotal.Text = "R$ " + Convert.ToString(Venda.ExibirValorTotal());            // <-- Sempre após add um produto à venda apresenta novamente o total //
    }

    private void txtQntProd_KeyPress(object sender, KeyPressEventArgs e)
    {
        Utilities.NumbersOnly(e);
    }

    private void F_Vendas_KeyDown(object sender, KeyEventArgs e)                            // <-- Trata o pressionamento das TECLAS DE ATALHO //
    {
        if (e.KeyCode == Keys.F1)
            btnConsultaProd_Click(sender, e);

        if (e.KeyCode == Keys.F2)
            btnAddProd_Click(sender, e);

        if (e.KeyCode == Keys.F5)
            btnRemoveProd_Click(sender, e);

        if (e.KeyCode == Keys.F8)
            btnLimpar_Click(sender, e);

    }

    private void btnRemoveProd_Click(object sender, EventArgs e)
    {

    }
}
