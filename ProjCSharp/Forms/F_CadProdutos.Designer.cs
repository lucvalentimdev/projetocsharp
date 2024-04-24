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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            BtnUploadImg = new Button();
            transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            BtnConfirmar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
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
            BtnCancelar.TabIndex = 2;
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
            BtnFechar.TabIndex = 1;
            BtnFechar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
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
            label2.Location = new Point(12, 190);
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
            label3.Location = new Point(12, 298);
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
            label4.Location = new Point(12, 245);
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
            label5.Location = new Point(129, 298);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 7;
            label5.Text = "Qnt. Inicial:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(458, 21);
            label8.Name = "label8";
            label8.Size = new Size(135, 17);
            label8.TabIndex = 10;
            label8.Text = "Imagem do Produto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 131);
            label9.Name = "label9";
            label9.Size = new Size(86, 17);
            label9.TabIndex = 11;
            label9.Text = "Publico Alvo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 79);
            label10.Name = "label10";
            label10.Size = new Size(48, 17);
            label10.TabIndex = 12;
            label10.Text = "Marca:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gainsboro;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Homens", "Mulheres", "Crianças", "Outros" });
            comboBox1.Location = new Point(14, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 99);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(286, 23);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(129, 318);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(75, 23);
            textBox6.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(458, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 192);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // BtnUploadImg
            // 
            BtnUploadImg.BackColor = Color.Transparent;
            BtnUploadImg.FlatAppearance.BorderSize = 0;
            BtnUploadImg.FlatAppearance.MouseDownBackColor = Color.LightGray;
            BtnUploadImg.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            BtnUploadImg.FlatStyle = FlatStyle.Flat;
            BtnUploadImg.ForeColor = Color.Transparent;
            BtnUploadImg.ImageIndex = 4;
            BtnUploadImg.ImageList = imageListIcons;
            BtnUploadImg.Location = new Point(631, 239);
            BtnUploadImg.Name = "BtnUploadImg";
            BtnUploadImg.Size = new Size(75, 23);
            BtnUploadImg.TabIndex = 21;
            BtnUploadImg.UseVisualStyleBackColor = false;
            // 
            // F_CadProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(BtnUploadImg);
            Controls.Add(pictureBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
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
            transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private Button BtnUploadImg;
    }
}