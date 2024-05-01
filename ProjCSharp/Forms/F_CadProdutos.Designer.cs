namespace SalSystem.Forms
{
    partial class F_CadProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CadProdutos));
            transparentPanel1 = new Views.Utils.TransparentPanel();
            BtnAdicionar = new Button();
            imageListIcons = new ImageList(components);
            BtnConfirmar = new Button();
            BtnConsultar = new Button();
            BtnCancelar = new Button();
            BtnFechar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            cboPublico = new ComboBox();
            txtNomeProd = new TextBox();
            txtCategoria = new TextBox();
            txtVolume = new TextBox();
            txtPreco = new TextBox();
            txtMarca = new TextBox();
            txtQntInicial = new TextBox();
            openFileDialog = new OpenFileDialog();
            groupBox1 = new GroupBox();
            BtnRemoverImg = new Button();
            BtnUploadImg = new Button();
            imgProduto = new PictureBox();
            txtDescricao = new TextBox();
            labellb = new Label();
            label6 = new Label();
            txtIDProd = new TextBox();
            label7 = new Label();
            transparentPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProduto).BeginInit();
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
            transparentPanel1.Location = new Point(0, 504);
            transparentPanel1.Name = "transparentPanel1";
            transparentPanel1.Size = new Size(784, 57);
            transparentPanel1.TabIndex = 2;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Cursor = Cursors.Hand;
            BtnAdicionar.FlatAppearance.BorderSize = 0;
            BtnAdicionar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnAdicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnAdicionar.FlatStyle = FlatStyle.Flat;
            BtnAdicionar.ForeColor = Color.LimeGreen;
            BtnAdicionar.ImageIndex = 4;
            BtnAdicionar.ImageList = imageListIcons;
            BtnAdicionar.Location = new Point(203, 8);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(70, 40);
            BtnAdicionar.TabIndex = 1;
            BtnAdicionar.TabStop = false;
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
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
            imageListIcons.Images.SetKeyName(7, "photo_up.png");
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Cursor = Cursors.Hand;
            BtnConfirmar.Enabled = false;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.ForeColor = Color.LimeGreen;
            BtnConfirmar.ImageIndex = 3;
            BtnConfirmar.ImageList = imageListIcons;
            BtnConfirmar.Location = new Point(279, 8);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(70, 40);
            BtnConfirmar.TabIndex = 2;
            BtnConfirmar.TabStop = false;
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Cursor = Cursors.Hand;
            BtnConsultar.FlatAppearance.BorderSize = 0;
            BtnConsultar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.ForeColor = Color.DodgerBlue;
            BtnConsultar.ImageIndex = 1;
            BtnConsultar.ImageList = imageListIcons;
            BtnConsultar.Location = new Point(355, 8);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(70, 40);
            BtnConsultar.TabIndex = 3;
            BtnConsultar.TabStop = false;
            BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Transparent;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.Enabled = false;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.ForeColor = Color.DarkRed;
            BtnCancelar.ImageIndex = 0;
            BtnCancelar.ImageList = imageListIcons;
            BtnCancelar.Location = new Point(431, 8);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(70, 40);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.TabStop = false;
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.BackgroundImageLayout = ImageLayout.Center;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.FlatAppearance.BorderSize = 0;
            BtnFechar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.ForeColor = Color.DarkRed;
            BtnFechar.ImageIndex = 5;
            BtnFechar.ImageList = imageListIcons;
            BtnFechar.Location = new Point(507, 8);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.RightToLeft = RightToLeft.No;
            BtnFechar.Size = new Size(70, 40);
            BtnFechar.TabIndex = 5;
            BtnFechar.TabStop = false;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 3;
            label1.Text = "Nome Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 213);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 4;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 321);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 5;
            label3.Text = "Preço Unt.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(279, 213);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 6;
            label4.Text = "Volume:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(129, 321);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 7;
            label5.Text = "Qnt. Inicial:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 102);
            label10.Name = "label10";
            label10.Size = new Size(48, 17);
            label10.TabIndex = 12;
            label10.Text = "Marca:";
            // 
            // cboPublico
            // 
            cboPublico.BackColor = Color.LightGray;
            cboPublico.Enabled = false;
            cboPublico.FormattingEnabled = true;
            cboPublico.Items.AddRange(new object[] { "Homens", "Mulheres", "Crianças", "Outros" });
            cboPublico.Location = new Point(14, 174);
            cboPublico.Name = "cboPublico";
            cboPublico.Size = new Size(190, 23);
            cboPublico.TabIndex = 2;
            // 
            // txtNomeProd
            // 
            txtNomeProd.BackColor = Color.LightGray;
            txtNomeProd.Enabled = false;
            txtNomeProd.Location = new Point(14, 64);
            txtNomeProd.MaxLength = 300;
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(373, 23);
            txtNomeProd.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.LightGray;
            txtCategoria.Enabled = false;
            txtCategoria.Location = new Point(12, 233);
            txtCategoria.MaxLength = 150;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(269, 23);
            txtCategoria.TabIndex = 3;
            // 
            // txtVolume
            // 
            txtVolume.BackColor = Color.LightGray;
            txtVolume.Enabled = false;
            txtVolume.Location = new Point(287, 233);
            txtVolume.MaxLength = 3;
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(100, 23);
            txtVolume.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.LightGray;
            txtPreco.Enabled = false;
            txtPreco.Location = new Point(12, 341);
            txtPreco.MaxLength = 8;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.LightGray;
            txtMarca.Enabled = false;
            txtMarca.Location = new Point(14, 122);
            txtMarca.MaxLength = 200;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(373, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtQntInicial
            // 
            txtQntInicial.BackColor = Color.LightGray;
            txtQntInicial.Enabled = false;
            txtQntInicial.Location = new Point(129, 341);
            txtQntInicial.MaxLength = 4;
            txtQntInicial.Name = "txtQntInicial";
            txtQntInicial.Size = new Size(75, 23);
            txtQntInicial.TabIndex = 7;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(BtnRemoverImg);
            groupBox1.Controls.Add(BtnUploadImg);
            groupBox1.Controls.Add(imgProduto);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(470, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 312);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagem do Produto:";
            // 
            // BtnRemoverImg
            // 
            BtnRemoverImg.Cursor = Cursors.Hand;
            BtnRemoverImg.Enabled = false;
            BtnRemoverImg.FlatAppearance.BorderSize = 0;
            BtnRemoverImg.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnRemoverImg.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnRemoverImg.FlatStyle = FlatStyle.Flat;
            BtnRemoverImg.ImageIndex = 6;
            BtnRemoverImg.ImageList = imageListIcons;
            BtnRemoverImg.Location = new Point(231, 247);
            BtnRemoverImg.Name = "BtnRemoverImg";
            BtnRemoverImg.Size = new Size(48, 40);
            BtnRemoverImg.TabIndex = 9;
            BtnRemoverImg.UseVisualStyleBackColor = true;
            BtnRemoverImg.Click += BtnRemoverImg_Click;
            // 
            // BtnUploadImg
            // 
            BtnUploadImg.BackColor = Color.Transparent;
            BtnUploadImg.Cursor = Cursors.Hand;
            BtnUploadImg.Enabled = false;
            BtnUploadImg.FlatAppearance.BorderSize = 0;
            BtnUploadImg.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnUploadImg.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnUploadImg.FlatStyle = FlatStyle.Flat;
            BtnUploadImg.ForeColor = Color.Transparent;
            BtnUploadImg.ImageIndex = 7;
            BtnUploadImg.ImageList = imageListIcons;
            BtnUploadImg.Location = new Point(185, 247);
            BtnUploadImg.Name = "BtnUploadImg";
            BtnUploadImg.Size = new Size(48, 40);
            BtnUploadImg.TabIndex = 8;
            BtnUploadImg.UseVisualStyleBackColor = false;
            BtnUploadImg.Click += BtnUploadImg_Click;
            // 
            // imgProduto
            // 
            imgProduto.BackColor = Color.Honeydew;
            imgProduto.BorderStyle = BorderStyle.Fixed3D;
            imgProduto.ErrorImage = Properties.Resources.not_img_128x128;
            imgProduto.Image = (Image)resources.GetObject("imgProduto.Image");
            imgProduto.Location = new Point(26, 20);
            imgProduto.Name = "imgProduto";
            imgProduto.Size = new Size(265, 221);
            imgProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgProduto.TabIndex = 22;
            imgProduto.TabStop = false;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.LightGray;
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(12, 291);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(375, 23);
            txtDescricao.TabIndex = 5;
            // 
            // labellb
            // 
            labellb.AutoSize = true;
            labellb.BackColor = Color.Transparent;
            labellb.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labellb.Location = new Point(12, 271);
            labellb.Name = "labellb";
            labellb.Size = new Size(106, 17);
            labellb.TabIndex = 24;
            labellb.Text = "Breve Descrição:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 25;
            label6.Text = "Publico Alvo:";
            // 
            // txtIDProd
            // 
            txtIDProd.BackColor = Color.LightGray;
            txtIDProd.BorderStyle = BorderStyle.None;
            txtIDProd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtIDProd.ForeColor = Color.Red;
            txtIDProd.Location = new Point(91, 17);
            txtIDProd.Name = "txtIDProd";
            txtIDProd.ReadOnly = true;
            txtIDProd.Size = new Size(64, 20);
            txtIDProd.TabIndex = 26;
            txtIDProd.TabStop = false;
            txtIDProd.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(14, 17);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 27;
            label7.Text = "CÓDIGO:";
            // 
            // F_CadProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(label7);
            Controls.Add(txtIDProd);
            Controls.Add(label6);
            Controls.Add(labellb);
            Controls.Add(txtDescricao);
            Controls.Add(groupBox1);
            Controls.Add(txtQntInicial);
            Controls.Add(txtMarca);
            Controls.Add(txtPreco);
            Controls.Add(txtVolume);
            Controls.Add(txtCategoria);
            Controls.Add(txtNomeProd);
            Controls.Add(cboPublico);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(transparentPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_CadProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_CadProdutos";
            Load += F_CadProdutos_Load;
            transparentPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Views.Utils.TransparentPanel transparentPanel1;
        private Button BtnAdicionar;
        private Button BtnConfirmar;
        private Button BtnConsultar;
        private Button BtnCancelar;
        private Button BtnFechar;
        private ImageList imageListIcons;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label10;
        private ComboBox cboPublico;
        private TextBox txtNomeProd;
        private TextBox txtCategoria;
        private TextBox txtVolume;
        private TextBox txtPreco;
        private TextBox txtMarca;
        private TextBox txtQntInicial;
        private OpenFileDialog openFileDialog;
        private GroupBox groupBox1;
        private Button BtnUploadImg;
        private PictureBox imgProduto;
        private Button BtnRemoverImg;
        private TextBox txtDescricao;
        private Label labellb;
        private Label label6;
        private TextBox txtIDProd;
        private Label label7;
    }
}