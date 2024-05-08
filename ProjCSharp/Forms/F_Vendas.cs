using SalSystem.Models;
using SalSystem.Services;

namespace SalSystem.Forms;

public partial class F_Vendas : Form
{
    public F_Vendas()
    {
        InitializeComponent();
    }
    //Var//
    private static List<Venda> listaVendas = [];
      

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        rtPedido.Clear();
        cboFormaReceb.Text = "";
        txtTotalItens.Text = string.Empty;
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
        if (txtCodProd.Text == "")
            return;

        for (int i = 0; i < Convert.ToInt32(txtQntProd.Text); i++)
        {
            Venda venda = new(0, txtNomeProd.Text, Convert.ToInt32(txtCodProd.Text), 1, Convert.ToDouble(txtValorUnitario.Text));
            _ = venda.CalcularSubTotal();
            listaVendas.Add(venda);                                                             //<-- Alimenta a lista de vendas com a Venda pré concluída //
            ExibirDetalhesVendas(listaVendas);
        }
    }

    private void btnRemoveProd_Click(object sender, EventArgs e)
    {
        listaVendas.RemoveAt(listaVendas.Count - 1);
        Venda.totais = Venda.totais - Convert.ToInt32(txtValorUnitario.Text);
        ExibirDetalhesVendas(listaVendas);
    }

    private void txtQntProd_KeyPress(object sender, KeyPressEventArgs e)
    {
        Utilities.NumbersOnly(e);
    }

    private void F_Vendas_KeyDown(object sender, KeyEventArgs e)                            // -- Trata o pressionamento das TECLAS DE ATALHO --- //
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

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        Utilities.NumbersOnly(e);
    }

    private void txtPercDescontos_Leave(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtPercDescontos.Text) > 100)
        {
            Utilities.MessageCaution("Desconto não pode ser maior a 100%");
        }
        txtValorReceber.Text = Convert.ToString(Venda.CalcularTotalFinal(Convert.ToDouble(txtTotalItens.Text), Convert.ToDouble(txtPercDescontos.Text)));
    }

    private void txtPercDescontos_Enter(object sender, EventArgs e)
    {
        txtPercDescontos.Text = string.Empty;
    }

    private void ExibirDetalhesVendas(List<Venda> _listaVendas)
    {
        rtPedido.Clear();

        foreach (Venda _venda in _listaVendas)
        {
            string _detalhes = "Cód: " + _venda.IdProdVenda.ToString() + " Prod.: " + _venda.NomeProd.ToString() + " Qnt.: " + _venda.Quantidade.ToString() + " Vl.Unt.: " + _venda.Preco.ToString() + "\r\n";

            rtPedido.AppendText(_detalhes);      // Adiciona os detalhes da venda ao RichTextBox //  
        }
        
       txtTotalItens.Text = Convert.ToString(Venda.totais);
    }
}
