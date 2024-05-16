namespace SalSystem.Forms
{
    partial class F_Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Caixa));
            gridCaixa = new DataGridView();
            btnConsultar = new Button();
            imageList1 = new ImageList(components);
            btnLimpar = new Button();
            btnFechar = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            txtCPF = new TextBox();
            groupBox3 = new GroupBox();
            cboFormaReceb = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dateFinal = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            dateInicio = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridCaixa).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gridCaixa
            // 
            gridCaixa.AllowUserToAddRows = false;
            gridCaixa.AllowUserToDeleteRows = false;
            gridCaixa.AllowUserToResizeColumns = false;
            gridCaixa.AllowUserToResizeRows = false;
            gridCaixa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gridCaixa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCaixa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridCaixa.BackgroundColor = SystemColors.ButtonFace;
            gridCaixa.BorderStyle = BorderStyle.Fixed3D;
            gridCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCaixa.Location = new Point(0, 160);
            gridCaixa.Name = "gridCaixa";
            gridCaixa.ReadOnly = true;
            gridCaixa.Size = new Size(985, 420);
            gridCaixa.TabIndex = 0;
            gridCaixa.TabStop = false;
            // 
            // btnConsultar
            // 
            btnConsultar.FlatAppearance.BorderSize = 2;
            btnConsultar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.IndianRed;
            btnConsultar.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultar.ImageIndex = 0;
            btnConsultar.ImageList = imageList1;
            btnConsultar.Location = new Point(312, 603);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 44);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += BtnConsultar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "busca.png");
            imageList1.Images.SetKeyName(1, "voltar.png");
            imageList1.Images.SetKeyName(2, "sweep.png");
            // 
            // btnLimpar
            // 
            btnLimpar.FlatAppearance.BorderSize = 2;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.IndianRed;
            btnLimpar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpar.ImageIndex = 2;
            btnLimpar.ImageList = imageList1;
            btnLimpar.Location = new Point(433, 603);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(115, 44);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.MiddleLeft;
            btnLimpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 2;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFechar.ForeColor = Color.IndianRed;
            btnFechar.ImageAlign = ContentAlignment.MiddleRight;
            btnFechar.ImageIndex = 1;
            btnFechar.ImageList = imageList1;
            btnFechar.Location = new Point(554, 603);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(115, 44);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.TextAlign = ContentAlignment.MiddleLeft;
            btnFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += BtnFechar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(985, 136);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros para carregar o extrato:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtCPF);
            groupBox4.ForeColor = Color.DimGray;
            groupBox4.Location = new Point(710, 30);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(262, 100);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Selecione por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 28);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 6;
            label3.Text = "CPF - Cliente:";
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.Info;
            txtCPF.BorderStyle = BorderStyle.FixedSingle;
            txtCPF.Location = new Point(8, 48);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(233, 25);
            txtCPF.TabIndex = 5;
            txtCPF.TextAlign = HorizontalAlignment.Center;
            txtCPF.KeyPress += TxtCPF_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboFormaReceb);
            groupBox3.Controls.Add(label2);
            groupBox3.ForeColor = Color.DimGray;
            groupBox3.Location = new Point(412, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(292, 100);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Selecione o tipo de:";
            // 
            // cboFormaReceb
            // 
            cboFormaReceb.BackColor = SystemColors.Info;
            cboFormaReceb.FlatStyle = FlatStyle.System;
            cboFormaReceb.FormattingEnabled = true;
            cboFormaReceb.Items.AddRange(new object[] { "Dinheiro", "PIX", "Cartão " });
            cboFormaReceb.Location = new Point(11, 48);
            cboFormaReceb.Name = "cboFormaReceb";
            cboFormaReceb.Size = new Size(260, 25);
            cboFormaReceb.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 28);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 6;
            label2.Text = "Forma Recebimento:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateFinal);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateInicio);
            groupBox2.ForeColor = Color.DimGray;
            groupBox2.Location = new Point(6, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selecione período de venda:";
            // 
            // dateFinal
            // 
            dateFinal.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dateFinal.CalendarMonthBackground = SystemColors.Info;
            dateFinal.Location = new Point(91, 60);
            dateFinal.Name = "dateFinal";
            dateFinal.Size = new Size(299, 25);
            dateFinal.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 66);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 4;
            label4.Text = "Data Final:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 3;
            label1.Text = "Data Início:";
            // 
            // dateInicio
            // 
            dateInicio.CalendarMonthBackground = SystemColors.Info;
            dateInicio.Location = new Point(91, 24);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(299, 25);
            dateInicio.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(6, 140);
            label5.Name = "label5";
            label5.Size = new Size(145, 19);
            label5.TabIndex = 5;
            label5.Text = "Resultado - Extrato :";
            // 
            // F_Caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 195, 195);
            ClientSize = new Size(984, 661);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(btnFechar);
            Controls.Add(btnLimpar);
            Controls.Add(btnConsultar);
            Controls.Add(gridCaixa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Caixa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Caixa";
            Load += F_Caixa_Load;
            ((System.ComponentModel.ISupportInitialize)gridCaixa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridCaixa;
        private Button btnConsultar;
        private Button btnLimpar;
        private Button btnFechar;
        private GroupBox groupBox1;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private Label label1;
        private DateTimePicker dateInicio;
        private DateTimePicker dateFinal;
        private Label label4;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox txtCPF;
        private GroupBox groupBox3;
        private ComboBox cboFormaReceb;
        private Label label2;
        private Label label5;
    }
}