namespace SalSystem.Views
{
    partial class F_CadClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CadClientes));
            transparentPanel1 = new Utils.TransparentPanel();
            BtnAdicionar = new Button();
            imageListIcons = new ImageList(components);
            BtnConfirmar = new Button();
            BtnConsultar = new Button();
            BtnCancelar = new Button();
            BtnFechar = new Button();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtTelefone = new TextBox();
            TxtCEP = new TextBox();
            txtCidade = new TextBox();
            txtLogradouro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            chkNaoInfoCPF = new CheckBox();
            textBox7 = new TextBox();
            rtfObservacao = new RichTextBox();
            BtnEdtEndereco = new Button();
            cboUF = new ComboBox();
            transparentPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // transparentPanel1
            // 
            transparentPanel1.BackColor = Color.Transparent;
            transparentPanel1.Controls.Add(BtnAdicionar);
            transparentPanel1.Controls.Add(BtnConfirmar);
            transparentPanel1.Controls.Add(BtnConsultar);
            transparentPanel1.Controls.Add(BtnCancelar);
            transparentPanel1.Controls.Add(BtnFechar);
            transparentPanel1.Dock = DockStyle.Bottom;
            transparentPanel1.Location = new Point(0, 486);
            transparentPanel1.Name = "transparentPanel1";
            transparentPanel1.Size = new Size(770, 57);
            transparentPanel1.TabIndex = 1;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Cursor = Cursors.Hand;
            BtnAdicionar.FlatAppearance.BorderSize = 0;
            BtnAdicionar.FlatStyle = FlatStyle.Flat;
            BtnAdicionar.ForeColor = Color.LimeGreen;
            BtnAdicionar.ImageIndex = 4;
            BtnAdicionar.ImageList = imageListIcons;
            BtnAdicionar.Location = new Point(203, 8);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(70, 40);
            BtnAdicionar.TabIndex = 5;
            BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "cancelar.png");
            imageListIcons.Images.SetKeyName(1, "busca.png");
            imageListIcons.Images.SetKeyName(2, "editar.png");
            imageListIcons.Images.SetKeyName(3, "confirmar.png");
            imageListIcons.Images.SetKeyName(4, "adicionar.png");
            imageListIcons.Images.SetKeyName(5, "voltar.png");
            imageListIcons.Images.SetKeyName(6, "delete.png");
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Cursor = Cursors.Hand;
            BtnConfirmar.Enabled = false;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.ForeColor = Color.LimeGreen;
            BtnConfirmar.ImageIndex = 3;
            BtnConfirmar.ImageList = imageListIcons;
            BtnConfirmar.Location = new Point(279, 8);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(70, 40);
            BtnConfirmar.TabIndex = 4;
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Cursor = Cursors.Hand;
            BtnConsultar.FlatAppearance.BorderSize = 0;
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.ForeColor = Color.DodgerBlue;
            BtnConsultar.ImageIndex = 1;
            BtnConsultar.ImageList = imageListIcons;
            BtnConsultar.Location = new Point(355, 8);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(70, 40);
            BtnConsultar.TabIndex = 3;
            BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Transparent;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.Enabled = false;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.ForeColor = Color.DarkRed;
            BtnCancelar.ImageIndex = 0;
            BtnCancelar.ImageList = imageListIcons;
            BtnCancelar.Location = new Point(431, 8);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(70, 40);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.BackgroundImageLayout = ImageLayout.Center;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.FlatAppearance.BorderSize = 0;
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.ForeColor = Color.DarkRed;
            BtnFechar.ImageIndex = 5;
            BtnFechar.ImageList = imageListIcons;
            BtnFechar.Location = new Point(507, 8);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.RightToLeft = RightToLeft.No;
            BtnFechar.Size = new Size(70, 40);
            BtnFechar.TabIndex = 1;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(30, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(442, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(30, 80);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(177, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(30, 126);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(177, 23);
            txtTelefone.TabIndex = 4;
            // 
            // TxtCEP
            // 
            TxtCEP.Location = new Point(30, 172);
            TxtCEP.MaxLength = 8;
            TxtCEP.Name = "TxtCEP";
            TxtCEP.Size = new Size(101, 23);
            TxtCEP.TabIndex = 5;
            TxtCEP.KeyPress += TxtCEP_KeyPress;
            TxtCEP.Leave += TxtCEP_Leave;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.LightGray;
            txtCidade.Location = new Point(137, 172);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(335, 23);
            txtCidade.TabIndex = 6;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(30, 218);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(349, 23);
            txtLogradouro.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 8;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 244);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 9;
            label2.Text = "Observações:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(388, 198);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 10;
            label3.Text = "Nº-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 198);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 11;
            label4.Text = "Logradouro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(137, 152);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 12;
            label5.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 152);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 13;
            label6.Text = "CEP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 106);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 14;
            label7.Text = "Telefone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 60);
            label8.Name = "label8";
            label8.Size = new Size(34, 17);
            label8.TabIndex = 15;
            label8.Text = "CPF:";
            // 
            // chkNaoInfoCPF
            // 
            chkNaoInfoCPF.AutoSize = true;
            chkNaoInfoCPF.BackColor = Color.Transparent;
            chkNaoInfoCPF.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkNaoInfoCPF.Location = new Point(213, 84);
            chkNaoInfoCPF.Name = "chkNaoInfoCPF";
            chkNaoInfoCPF.Size = new Size(96, 19);
            chkNaoInfoCPF.TabIndex = 16;
            chkNaoInfoCPF.Text = "Não Informar";
            chkNaoInfoCPF.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(385, 218);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(87, 23);
            textBox7.TabIndex = 17;
            // 
            // rtfObservacao
            // 
            rtfObservacao.Location = new Point(30, 264);
            rtfObservacao.Name = "rtfObservacao";
            rtfObservacao.Size = new Size(577, 216);
            rtfObservacao.TabIndex = 18;
            rtfObservacao.Text = "";
            // 
            // BtnEdtEndereco
            // 
            BtnEdtEndereco.BackColor = Color.Transparent;
            BtnEdtEndereco.FlatAppearance.BorderSize = 0;
            BtnEdtEndereco.FlatStyle = FlatStyle.Flat;
            BtnEdtEndereco.ForeColor = Color.Transparent;
            BtnEdtEndereco.ImageIndex = 2;
            BtnEdtEndereco.ImageList = imageListIcons;
            BtnEdtEndereco.Location = new Point(571, 164);
            BtnEdtEndereco.Name = "BtnEdtEndereco";
            BtnEdtEndereco.Size = new Size(36, 36);
            BtnEdtEndereco.TabIndex = 19;
            BtnEdtEndereco.UseVisualStyleBackColor = false;
            // 
            // cboUF
            // 
            cboUF.BackColor = Color.LightGray;
            cboUF.Cursor = Cursors.Hand;
            cboUF.Enabled = false;
            cboUF.FormattingEnabled = true;
            cboUF.Items.AddRange(new object[] { "", "AL ", "AP ", "AM ", "BA ", "CE ", "DF ", "ES ", "GO ", "MA ", "MT ", "MS ", "MG ", "PA ", "PB ", "PR ", "PE ", "PI ", "RJ ", "RN ", "RS ", "RO ", "RR ", "SC ", "SP ", "SE ", "TO " });
            cboUF.Location = new Point(478, 172);
            cboUF.Name = "cboUF";
            cboUF.Size = new Size(87, 23);
            cboUF.TabIndex = 20;
            // 
            // F_CadClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 543);
            Controls.Add(cboUF);
            Controls.Add(BtnEdtEndereco);
            Controls.Add(rtfObservacao);
            Controls.Add(textBox7);
            Controls.Add(chkNaoInfoCPF);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCidade);
            Controls.Add(TxtCEP);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(transparentPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_CadClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Clientes";
            transparentPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Utils.TransparentPanel transparentPanel1;
        private Button BtnFechar;
        private ImageList imageListIcons;
        private Button BtnCancelar;
        private Button BtnConfirmar;
        private Button BtnConsultar;
        private Button BtnAdicionar;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private TextBox TxtCEP;
        private TextBox txtCidade;
        private TextBox txtLogradouro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox chkNaoInfoCPF;
        private TextBox textBox7;
        private RichTextBox rtfObservacao;
        private Button BtnEdtEndereco;
        private ComboBox cboUF;
    }
}