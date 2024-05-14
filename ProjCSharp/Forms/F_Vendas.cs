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
    private static List<ItensVenda> listaVendas = [];

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        listaVendas.Clear();
        rtPedido.Clear();
        cboFormaReceb.Text = "";
        txtTotalItens.Text = string.Empty;
        txtQntItens.Text = string.Empty;
        txtValorReceber.Text = string.Empty;
        txtPercDescontos.Text = "0";
        btnLimparClie_Click(sender, e);
        btnLimpar_Click(sender, e);
    }

    private void btnConsultaCliente_Click(object sender, EventArgs e)
    {
        if (txtCPF.Text == "")
            return;

        List<Cliente> _ListaClientes = new(Cliente.EncontrarCliente(txtCPF.Text));

        foreach (Cliente _cliente in _ListaClientes)
        {
            txtIdCliente.Text = Convert.ToString(_cliente.IdCliente);
            txtNomeCliente.Text = _cliente.Nome;
        }
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
            foreach (Produto _produto in _produtos)                              // <--- Acessa o objeto _produtos e dentro do laço carrega os dados para EXIBIÇÃO //
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
        txtCPF.Text = string.Empty;
        txtIdCliente.Text = string.Empty;
        txtNomeCliente.Text = string.Empty;
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        txtCodProd.Text = string.Empty;
        txtNomeProd.Text = string.Empty;
        txtDescricaoProd.Text = string.Empty;
        txtValorUnitario.Text = string.Empty;
        txtConsultaProd.Text = string.Empty;
        txtQntProd.Text = string.Empty;
        imgProduto.Image = Properties.Resources.not_img_128x128;
    }

    private void btnAddProd_Click(object sender, EventArgs e)
    {
        if (txtCodProd.Text == "")
            return;

        for (int i = 0; i < Convert.ToInt32(txtQntProd.Text); i++)                     //<-- Laço que controla as unidades a serem inseridas na lista //
        {
            ItensVenda venda = new(txtNomeProd.Text, Convert.ToInt32(txtCodProd.Text), 1, Convert.ToDouble(txtValorUnitario.Text));
            venda.CalcSubTotal_Itens();
            listaVendas.Add(venda);                                                    //<-- Alimenta a lista de vendas com a Venda pré concluída //
            ExibirDetalhesVendas(listaVendas);
        }
    }

    private void btnRemoveProd_Click(object sender, EventArgs e)
    {
        if (rtPedido.Text == "")
        {
            btnCancelar_Click(sender, e);
            return;
        }

        listaVendas.RemoveAt(listaVendas.Count - 1);                                   //<-- Remove o ultimo registro de Venda da Lista //
        ItensVenda.totaisItens -= Convert.ToDouble(txtValorUnitario.Text);             //<-- Subtrai o ultimo valor adicionado ao subtotal //
        ExibirDetalhesVendas(listaVendas);                                             //<-- Exibe a lista de vendas novamente //
    }

    private void txtQntProd_KeyPress(object sender, KeyPressEventArgs e)
    {
        Utilities.NumbersOnly(e);
    }

    private void F_Vendas_KeyDown(object sender, KeyEventArgs e)              //*** ---- Trata o pressionamento das TECLAS DE ATALHO ----- ***//
    {
        if (e.KeyCode == Keys.F1)
            btnConsultaProd_Click(sender, e);

        if (e.KeyCode == Keys.F2)
            btnAddProd_Click(sender, e);

        if (e.KeyCode == Keys.F5)
            btnRemoveProd_Click(sender, e);

        if (e.KeyCode == Keys.F6)
            btnLimpar_Click(sender, e);

        if (e.KeyCode == Keys.F9)
            btnCancelar_Click(sender, e);

        if (e.KeyCode == Keys.F12)
            btnConcluir_Click(sender, e);

        if (e.KeyCode == Keys.Escape)
            Close();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        Utilities.NumbersOnly(e);
    }

    private void txtPercDescontos_Leave(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtPercDescontos.Text) > 100)
        {
            Utilities.MessageCaution("Desconto não pode ser maior a 100% !");
            txtPercDescontos.Text = "0";
            return;
        }
    
        else
            txtValorReceber.Text = Convert.ToString(ItensVenda.CalcTotalItensFinal(Convert.ToDouble(txtTotalItens.Text), Convert.ToDouble(txtPercDescontos.Text)));
    }

    private void txtPercDescontos_Enter(object sender, EventArgs e)
    {
        txtPercDescontos.Text = string.Empty;
    }

    private void ExibirDetalhesVendas(List<ItensVenda> _listaVendas)     // ***--- Carrega a Exibição do item adicionado a VENDA ---*** //
    {
        rtPedido.Clear();

        foreach (ItensVenda _venda in _listaVendas)
        {
            string _detalhes = "Cód: " + _venda.IdProdVenda.ToString() + " Prod.: " + _venda.NomeProd.ToString() + " Qnt.: " + _venda.Quantidade.ToString() + " Vl.Unt.: " + _venda.Preco.ToString() + "\r\n";

            rtPedido.AppendText(_detalhes);                                 // <--- Adiciona os detalhes da venda ao RichTextBox //  
        }

        txtTotalItens.Text = Convert.ToString(ItensVenda.totaisItens);
    }

    private void btnConcluir_Click(object sender, EventArgs e)  //*** --- Instancia uma nova venda e em seguida aciona o metodo de Salvar venda ---***//  
    {
        if (txtPercDescontos.Text == "0")
            txtValorReceber.Text = txtTotalItens.Text;
        else
            txtPercDescontos_Leave(sender, e);                                  // <--- Aciona o calculo de descontos caso haja desconto //

        if (cboFormaReceb.Text == "")
        {
            Utilities.MessageCaution("Informe a forma de recebimento!");
            return;
        }

        double _valorDesconto = Convert.ToDouble(txtTotalItens.Text) - Convert.ToDouble(txtValorReceber.Text);

        Venda venda = new(Convert.ToInt32(txtIdCliente.Text), Convert.ToDouble(txtTotalItens.Text), _valorDesconto, Convert.ToDouble(txtValorReceber.Text), 1, cboFormaReceb.Text);
        string _log = venda.SalvarVenda();
        if (_log == "ok")
            Utilities.MessageInformation("Venda concluída com sucesso!");
        else if (_log == "erro_conn")
            Utilities.MessageError("Ocorreu um erro na conexão com o banco de dados!");
        else
            Utilities.MessageError(_log);

        btnCancelar_Click(sender, e);
    }

}
