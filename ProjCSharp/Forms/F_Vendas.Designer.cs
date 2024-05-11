namespace SalSystem.Forms
{
    partial class F_Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Vendas));
            groupBox1 = new GroupBox();
            txtIdCliente = new TextBox();
            label16 = new Label();
            btnLimparClie = new Button();
            imageList1 = new ImageList(components);
            txtCPF = new TextBox();
            txtNomeCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnConsultaCliente = new Button();
            groupBox2 = new GroupBox();
            rtPedido = new RichTextBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            txtQntProd = new TextBox();
            label11 = new Label();
            btnLimpar = new Button();
            txtNomeProd = new TextBox();
            label10 = new Label();
            btnRemoveProd = new Button();
            btnAddProd = new Button();
            label6 = new Label();
            txtValorUnitario = new TextBox();
            txtDescricaoProd = new TextBox();
            txtCodProd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnConsultaProd = new Button();
            txtConsultaProd = new TextBox();
            imgProduto = new PictureBox();
            groupBox4 = new GroupBox();
            label15 = new Label();
            txtValorReceber = new TextBox();
            label14 = new Label();
            txtPercDescontos = new TextBox();
            label13 = new Label();
            cboFormaReceb = new ComboBox();
            label9 = new Label();
            txtQntItens = new TextBox();
            label8 = new Label();
            txtTotalItens = new TextBox();
            label7 = new Label();
            btnCancelar = new Button();
            btnConcluir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProduto).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(btnLimparClie);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnConsultaCliente);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Cliente: ";
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = SystemColors.Window;
            txtIdCliente.BorderStyle = BorderStyle.None;
            txtIdCliente.Font = new Font("Segoe UI", 12F);
            txtIdCliente.ForeColor = Color.DimGray;
            txtIdCliente.Location = new Point(6, 41);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(83, 22);
            txtIdCliente.TabIndex = 12;
            txtIdCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(6, 21);
            label16.Name = "label16";
            label16.Size = new Size(71, 17);
            label16.TabIndex = 11;
            label16.Text = "Id.Cliente:";
            // 
            // btnLimparClie
            // 
            btnLimparClie.FlatAppearance.BorderSize = 2;
            btnLimparClie.FlatStyle = FlatStyle.Flat;
            btnLimparClie.ForeColor = Color.IndianRed;
            btnLimparClie.ImageIndex = 6;
            btnLimparClie.ImageList = imageList1;
            btnLimparClie.Location = new Point(444, 77);
            btnLimparClie.Name = "btnLimparClie";
            btnLimparClie.Size = new Size(115, 40);
            btnLimparClie.TabIndex = 10;
            btnLimparClie.Text = "Limpar";
            btnLimparClie.TextAlign = ContentAlignment.MiddleRight;
            btnLimparClie.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimparClie.UseVisualStyleBackColor = true;
            btnLimparClie.Click += btnLimparClie_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "advanced-search.png");
            imageList1.Images.SetKeyName(1, "agreement.png");
            imageList1.Images.SetKeyName(2, "chart.png");
            imageList1.Images.SetKeyName(3, "delist.png");
            imageList1.Images.SetKeyName(4, "membership-card_11252824.png");
            imageList1.Images.SetKeyName(5, "revenue.png");
            imageList1.Images.SetKeyName(6, "sweep.png");
            imageList1.Images.SetKeyName(7, "cancelar.png");
            // 
            // txtCPF
            // 
            txtCPF.BorderStyle = BorderStyle.FixedSingle;
            txtCPF.Font = new Font("Segoe UI", 11F);
            txtCPF.Location = new Point(140, 84);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(177, 27);
            txtCPF.TabIndex = 9;
            txtCPF.KeyPress += txtCPF_KeyPress;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.Window;
            txtNomeCliente.BorderStyle = BorderStyle.None;
            txtNomeCliente.Font = new Font("Segoe UI", 12F);
            txtNomeCliente.ForeColor = Color.DimGray;
            txtNomeCliente.Location = new Point(95, 41);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.ReadOnly = true;
            txtNomeCliente.Size = new Size(464, 22);
            txtNomeCliente.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(11, 88);
            label5.Name = "label5";
            label5.Size = new Size(123, 17);
            label5.TabIndex = 7;
            label5.Text = "Consultar por CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(95, 21);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 6;
            label4.Text = "Nome Cliente:";
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.Cursor = Cursors.Hand;
            btnConsultaCliente.FlatAppearance.BorderSize = 2;
            btnConsultaCliente.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnConsultaCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnConsultaCliente.FlatStyle = FlatStyle.Flat;
            btnConsultaCliente.ForeColor = Color.DarkBlue;
            btnConsultaCliente.ImageIndex = 0;
            btnConsultaCliente.ImageList = imageList1;
            btnConsultaCliente.Location = new Point(323, 76);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Size = new Size(115, 40);
            btnConsultaCliente.TabIndex = 0;
            btnConsultaCliente.Text = "Pesquisar";
            btnConsultaCliente.TextAlign = ContentAlignment.MiddleRight;
            btnConsultaCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaCliente.UseVisualStyleBackColor = true;
            btnConsultaCliente.Click += btnConsultaCliente_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtPedido);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.ForeColor = Color.IndianRed;
            groupBox2.Location = new Point(586, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 440);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de pedidos:";
            // 
            // rtPedido
            // 
            rtPedido.BackColor = SystemColors.ControlLightLight;
            rtPedido.BorderStyle = BorderStyle.FixedSingle;
            rtPedido.Font = new Font("Segoe UI", 9F);
            rtPedido.Location = new Point(6, 24);
            rtPedido.Name = "rtPedido";
            rtPedido.ReadOnly = true;
            rtPedido.Size = new Size(374, 394);
            rtPedido.TabIndex = 0;
            rtPedido.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtQntProd);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(btnLimpar);
            groupBox3.Controls.Add(txtNomeProd);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnRemoveProd);
            groupBox3.Controls.Add(btnAddProd);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtValorUnitario);
            groupBox3.Controls.Add(txtDescricaoProd);
            groupBox3.Controls.Add(txtCodProd);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnConsultaProd);
            groupBox3.Controls.Add(txtConsultaProd);
            groupBox3.Controls.Add(imgProduto);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox3.ForeColor = Color.IndianRed;
            groupBox3.Location = new Point(1, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(579, 521);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(220, 222);
            label12.Name = "label12";
            label12.Size = new Size(39, 17);
            label12.TabIndex = 17;
            label12.Text = "Qnt.:";
            // 
            // txtQntProd
            // 
            txtQntProd.BorderStyle = BorderStyle.FixedSingle;
            txtQntProd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtQntProd.ForeColor = Color.MediumBlue;
            txtQntProd.Location = new Point(265, 218);
            txtQntProd.Name = "txtQntProd";
            txtQntProd.Size = new Size(88, 27);
            txtQntProd.TabIndex = 16;
            txtQntProd.TextAlign = HorizontalAlignment.Center;
            txtQntProd.KeyPress += txtQntProd_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(95, 501);
            label11.Name = "label11";
            label11.Size = new Size(390, 15);
            label11.TabIndex = 15;
            label11.Text = "F1 - Buscar | F2 - Adicionar | F5 - Remover | F6 - Limpar | ESC - Fechar";
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderSize = 2;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.ImageIndex = 6;
            btnLimpar.ImageList = imageList1;
            btnLimpar.Location = new Point(413, 409);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(115, 44);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtNomeProd
            // 
            txtNomeProd.BackColor = SystemColors.ButtonHighlight;
            txtNomeProd.BorderStyle = BorderStyle.None;
            txtNomeProd.Font = new Font("Segoe UI", 12F);
            txtNomeProd.ForeColor = Color.DimGray;
            txtNomeProd.Location = new Point(220, 116);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.ReadOnly = true;
            txtNomeProd.Size = new Size(353, 22);
            txtNomeProd.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(220, 96);
            label10.Name = "label10";
            label10.Size = new Size(103, 17);
            label10.TabIndex = 12;
            label10.Text = "Nome Produto:";
            // 
            // btnRemoveProd
            // 
            btnRemoveProd.Cursor = Cursors.Hand;
            btnRemoveProd.FlatAppearance.BorderSize = 2;
            btnRemoveProd.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnRemoveProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnRemoveProd.FlatStyle = FlatStyle.Flat;
            btnRemoveProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoveProd.ImageIndex = 3;
            btnRemoveProd.ImageList = imageList1;
            btnRemoveProd.Location = new Point(292, 409);
            btnRemoveProd.Name = "btnRemoveProd";
            btnRemoveProd.Size = new Size(115, 44);
            btnRemoveProd.TabIndex = 11;
            btnRemoveProd.Text = "Remover";
            btnRemoveProd.TextAlign = ContentAlignment.MiddleRight;
            btnRemoveProd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRemoveProd.UseVisualStyleBackColor = true;
            btnRemoveProd.Click += btnRemoveProd_Click;
            // 
            // btnAddProd
            // 
            btnAddProd.Cursor = Cursors.Hand;
            btnAddProd.FlatAppearance.BorderSize = 2;
            btnAddProd.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnAddProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnAddProd.FlatStyle = FlatStyle.Flat;
            btnAddProd.ForeColor = Color.DarkBlue;
            btnAddProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProd.ImageIndex = 1;
            btnAddProd.ImageList = imageList1;
            btnAddProd.Location = new Point(171, 409);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(115, 44);
            btnAddProd.TabIndex = 10;
            btnAddProd.Text = "Adicionar";
            btnAddProd.TextAlign = ContentAlignment.MiddleRight;
            btnAddProd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(11, 333);
            label6.Name = "label6";
            label6.Size = new Size(255, 17);
            label6.TabIndex = 9;
            label6.Text = "Buscar por nome de produto ou código:";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.BackColor = SystemColors.ButtonHighlight;
            txtValorUnitario.BorderStyle = BorderStyle.None;
            txtValorUnitario.Font = new Font("Segoe UI", 12F);
            txtValorUnitario.ForeColor = Color.DimGray;
            txtValorUnitario.Location = new Point(467, 220);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.ReadOnly = true;
            txtValorUnitario.Size = new Size(106, 22);
            txtValorUnitario.TabIndex = 8;
            txtValorUnitario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescricaoProd
            // 
            txtDescricaoProd.BackColor = SystemColors.ButtonHighlight;
            txtDescricaoProd.BorderStyle = BorderStyle.None;
            txtDescricaoProd.Font = new Font("Segoe UI", 12F);
            txtDescricaoProd.ForeColor = Color.DimGray;
            txtDescricaoProd.Location = new Point(220, 168);
            txtDescricaoProd.Name = "txtDescricaoProd";
            txtDescricaoProd.ReadOnly = true;
            txtDescricaoProd.Size = new Size(353, 22);
            txtDescricaoProd.TabIndex = 7;
            // 
            // txtCodProd
            // 
            txtCodProd.BackColor = SystemColors.ButtonHighlight;
            txtCodProd.BorderStyle = BorderStyle.None;
            txtCodProd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCodProd.ForeColor = Color.DimGray;
            txtCodProd.Location = new Point(220, 63);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.ReadOnly = true;
            txtCodProd.Size = new Size(100, 22);
            txtCodProd.TabIndex = 6;
            txtCodProd.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(220, 43);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 5;
            label3.Text = "Cód. Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(359, 222);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 4;
            label2.Text = "Vlr.Unitário: R$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(220, 148);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 3;
            label1.Text = "Descrição item:";
            // 
            // btnConsultaProd
            // 
            btnConsultaProd.Cursor = Cursors.Hand;
            btnConsultaProd.FlatAppearance.BorderSize = 2;
            btnConsultaProd.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnConsultaProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnConsultaProd.FlatStyle = FlatStyle.Flat;
            btnConsultaProd.ForeColor = Color.DarkBlue;
            btnConsultaProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaProd.ImageIndex = 0;
            btnConsultaProd.ImageList = imageList1;
            btnConsultaProd.Location = new Point(50, 409);
            btnConsultaProd.Name = "btnConsultaProd";
            btnConsultaProd.Size = new Size(115, 44);
            btnConsultaProd.TabIndex = 2;
            btnConsultaProd.Text = "Buscar";
            btnConsultaProd.TextAlign = ContentAlignment.MiddleRight;
            btnConsultaProd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnConsultaProd.UseVisualStyleBackColor = true;
            btnConsultaProd.Click += btnConsultaProd_Click;
            // 
            // txtConsultaProd
            // 
            txtConsultaProd.BorderStyle = BorderStyle.FixedSingle;
            txtConsultaProd.Font = new Font("Segoe UI", 11F);
            txtConsultaProd.Location = new Point(11, 357);
            txtConsultaProd.Name = "txtConsultaProd";
            txtConsultaProd.Size = new Size(562, 27);
            txtConsultaProd.TabIndex = 1;
            // 
            // imgProduto
            // 
            imgProduto.BackgroundImageLayout = ImageLayout.Center;
            imgProduto.BorderStyle = BorderStyle.FixedSingle;
            imgProduto.ErrorImage = Properties.Resources.not_img_128x128;
            imgProduto.Image = Properties.Resources.not_img_128x128;
            imgProduto.Location = new Point(11, 33);
            imgProduto.Name = "imgProduto";
            imgProduto.Size = new Size(203, 251);
            imgProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgProduto.TabIndex = 0;
            imgProduto.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtValorReceber);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(txtPercDescontos);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(cboFormaReceb);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtQntItens);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtTotalItens);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(btnCancelar);
            groupBox4.Controls.Add(btnConcluir);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox4.ForeColor = Color.IndianRed;
            groupBox4.Location = new Point(586, 448);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(386, 209);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pagamento:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(119, 189);
            label15.Name = "label15";
            label15.Size = new Size(164, 15);
            label15.TabIndex = 18;
            label15.Text = "F9 - Cancelar | F12 - Concluir";
            // 
            // txtValorReceber
            // 
            txtValorReceber.BorderStyle = BorderStyle.None;
            txtValorReceber.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtValorReceber.ForeColor = Color.LightSeaGreen;
            txtValorReceber.Location = new Point(263, 149);
            txtValorReceber.Name = "txtValorReceber";
            txtValorReceber.ReadOnly = true;
            txtValorReceber.Size = new Size(112, 25);
            txtValorReceber.TabIndex = 25;
            txtValorReceber.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(263, 129);
            label14.Name = "label14";
            label14.Size = new Size(96, 17);
            label14.TabIndex = 24;
            label14.Text = "Total Receber:";
            // 
            // txtPercDescontos
            // 
            txtPercDescontos.BorderStyle = BorderStyle.FixedSingle;
            txtPercDescontos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtPercDescontos.ForeColor = Color.Red;
            txtPercDescontos.Location = new Point(263, 99);
            txtPercDescontos.MaxLength = 3;
            txtPercDescontos.Name = "txtPercDescontos";
            txtPercDescontos.Size = new Size(112, 27);
            txtPercDescontos.TabIndex = 23;
            txtPercDescontos.Text = "0";
            txtPercDescontos.TextAlign = HorizontalAlignment.Right;
            txtPercDescontos.Enter += txtPercDescontos_Enter;
            txtPercDescontos.KeyPress += textBox1_KeyPress;
            txtPercDescontos.Leave += txtPercDescontos_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.DarkRed;
            label13.Location = new Point(263, 79);
            label13.Name = "label13";
            label13.Size = new Size(91, 17);
            label13.TabIndex = 22;
            label13.Text = "Descontos %:";
            // 
            // cboFormaReceb
            // 
            cboFormaReceb.FormattingEnabled = true;
            cboFormaReceb.Items.AddRange(new object[] { "Dinheiro", "PIX", "Cartão " });
            cboFormaReceb.Location = new Point(6, 48);
            cboFormaReceb.Name = "cboFormaReceb";
            cboFormaReceb.Size = new Size(172, 25);
            cboFormaReceb.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(6, 28);
            label9.Name = "label9";
            label9.Size = new Size(135, 17);
            label9.TabIndex = 20;
            label9.Text = "Forma Recebimento:";
            // 
            // txtQntItens
            // 
            txtQntItens.BackColor = SystemColors.ControlLightLight;
            txtQntItens.BorderStyle = BorderStyle.None;
            txtQntItens.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtQntItens.Location = new Point(184, 51);
            txtQntItens.Name = "txtQntItens";
            txtQntItens.ReadOnly = true;
            txtQntItens.Size = new Size(73, 22);
            txtQntItens.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(263, 28);
            label8.Name = "label8";
            label8.Size = new Size(94, 17);
            label8.TabIndex = 18;
            label8.Text = "Vl.Total Itens:";
            // 
            // txtTotalItens
            // 
            txtTotalItens.BackColor = SystemColors.ControlLightLight;
            txtTotalItens.BorderStyle = BorderStyle.None;
            txtTotalItens.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTotalItens.Location = new Point(263, 51);
            txtTotalItens.Name = "txtTotalItens";
            txtTotalItens.ReadOnly = true;
            txtTotalItens.Size = new Size(112, 22);
            txtTotalItens.TabIndex = 17;
            txtTotalItens.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(184, 28);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 16;
            label7.Text = "Qnt. Itens:";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 3;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.IndianRed;
            btnCancelar.ImageIndex = 7;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(136, 130);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 44);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConcluir
            // 
            btnConcluir.Cursor = Cursors.Hand;
            btnConcluir.FlatAppearance.BorderSize = 3;
            btnConcluir.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnConcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnConcluir.FlatStyle = FlatStyle.Flat;
            btnConcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnConcluir.ForeColor = Color.Green;
            btnConcluir.ImageIndex = 5;
            btnConcluir.ImageList = imageList1;
            btnConcluir.Location = new Point(15, 130);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(115, 44);
            btnConcluir.TabIndex = 14;
            btnConcluir.Text = "Concluir";
            btnConcluir.TextAlign = ContentAlignment.MiddleRight;
            btnConcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // F_Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 195, 195);
            ClientSize = new Size(984, 661);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "F_Vendas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vendas - Mini PDV";
            KeyDown += F_Vendas_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgProduto).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox imgProduto;
        private Button btnConsultaProd;
        private TextBox txtConsultaProd;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtValorUnitario;
        private TextBox txtDescricaoProd;
        private TextBox txtCodProd;
        private Label label5;
        private Label label4;
        private Button btnConsultaCliente;
        private TextBox txtCPF;
        private TextBox txtNomeCliente;
        private Label label6;
        private ImageList imageList1;
        private Button btnRemoveProd;
        private Button btnAddProd;
        private GroupBox groupBox4;
        private TextBox txtQntItens;
        private Label label8;
        private TextBox txtTotalItens;
        private Label label7;
        private Button btnCancelar;
        private Button btnConcluir;
        private ComboBox cboFormaReceb;
        private Label label9;
        private Label label10;
        private TextBox txtNomeProd;
        private Button btnLimpar;
        private Label label11;
        private Button btnLimparClie;
        private RichTextBox rtPedido;
        private Label label12;
        private TextBox txtQntProd;
        private TextBox txtPercDescontos;
        private Label label13;
        private TextBox txtValorReceber;
        private Label label14;
        private Label label15;
        private TextBox txtIdCliente;
        private Label label16;
    }
}