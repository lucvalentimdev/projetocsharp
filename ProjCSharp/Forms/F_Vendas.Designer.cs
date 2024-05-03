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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button6 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Cliente: ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(11, 89);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(193, 25);
            textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(11, 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(313, 25);
            textBox5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(11, 69);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 7;
            label5.Text = "CPF Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(11, 21);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 6;
            label4.Text = "Nome Cliente:";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.DarkGreen;
            button2.ImageIndex = 4;
            button2.ImageList = imageList1;
            button2.Location = new Point(210, 80);
            button2.Name = "button2";
            button2.Size = new Size(115, 40);
            button2.TabIndex = 0;
            button2.Text = "Pesquisar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
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
            imageList1.Images.SetKeyName(6, "cancelar.png");
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.ForeColor = Color.IndianRed;
            groupBox2.Location = new Point(486, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 399);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de pedidos:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox3.ForeColor = Color.IndianRed;
            groupBox3.Location = new Point(1, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(479, 521);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto: ";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ImageIndex = 3;
            button4.ImageList = imageList1;
            button4.Location = new Point(298, 444);
            button4.Name = "button4";
            button4.Size = new Size(115, 44);
            button4.TabIndex = 11;
            button4.Text = "Remover";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 1;
            button3.ImageList = imageList1;
            button3.Location = new Point(177, 444);
            button3.Name = "button3";
            button3.Size = new Size(115, 44);
            button3.TabIndex = 10;
            button3.Text = "Adicionar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(11, 357);
            label6.Name = "label6";
            label6.Size = new Size(239, 17);
            label6.TabIndex = 9;
            label6.Text = "Buscar por nome de produto ou cód.:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 25);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(192, 42);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 5;
            label3.Text = "Cód. Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(192, 248);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 4;
            label2.Text = "Valor unitário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(192, 139);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 3;
            label1.Text = "Descrição item:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new Point(53, 445);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 377);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 25);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(11, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 251);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(button5);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox4.ForeColor = Color.IndianRed;
            groupBox4.Location = new Point(486, 407);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(386, 250);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pagamento:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 25);
            comboBox1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(81, 21);
            label9.Name = "label9";
            label9.Size = new Size(135, 17);
            label9.TabIndex = 20;
            label9.Text = "Forma Recebimento:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(81, 106);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 25);
            textBox8.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(217, 86);
            label8.Name = "label8";
            label8.Size = new Size(77, 17);
            label8.TabIndex = 18;
            label8.Text = "Valor total:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(217, 106);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 25);
            textBox7.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(81, 86);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 16;
            label7.Text = "Qnt. Itens:";
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button6.ForeColor = Color.Red;
            button6.ImageIndex = 6;
            button6.ImageList = imageList1;
            button6.Location = new Point(202, 173);
            button6.Name = "button6";
            button6.Size = new Size(115, 44);
            button6.TabIndex = 15;
            button6.Text = "Cancelar";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button5.ForeColor = Color.DarkCyan;
            button5.ImageIndex = 5;
            button5.ImageList = imageList1;
            button5.Location = new Point(81, 173);
            button5.Name = "button5";
            button5.Size = new Size(115, 44);
            button5.TabIndex = 14;
            button5.Text = "Concluir";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // F_Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Vendas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Button button2;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private ImageList imageList1;
        private Button button4;
        private Button button3;
        private GroupBox groupBox4;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox7;
        private Label label7;
        private Button button6;
        private Button button5;
        private ComboBox comboBox1;
        private Label label9;
    }
}