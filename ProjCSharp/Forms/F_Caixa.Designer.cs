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
            btnLimpar = new Button();
            btnFechar = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)gridCaixa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridCaixa
            // 
            gridCaixa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gridCaixa.BackgroundColor = SystemColors.ControlLightLight;
            gridCaixa.BorderStyle = BorderStyle.Fixed3D;
            gridCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCaixa.Location = new Point(0, 104);
            gridCaixa.Name = "gridCaixa";
            gridCaixa.Size = new Size(985, 476);
            gridCaixa.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.FlatAppearance.BorderSize = 2;
            btnConsultar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.IndianRed;
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
            // btnLimpar
            // 
            btnLimpar.FlatAppearance.BorderSize = 2;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.IndianRed;
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
            btnFechar.Location = new Point(554, 603);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(115, 44);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.TextAlign = ContentAlignment.MiddleLeft;
            btnFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(985, 97);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione os filtros para carregar o extrato:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(291, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 25);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(517, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 21);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 3;
            label3.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 21);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 2;
            label2.Text = "Forma Receb.:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 1;
            label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(273, 25);
            dateTimePicker1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // F_Caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 195, 195);
            ClientSize = new Size(984, 661);
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
            ((System.ComponentModel.ISupportInitialize)gridCaixa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCaixa;
        private Button btnConsultar;
        private Button btnLimpar;
        private Button btnFechar;
        private GroupBox groupBox1;
        private ImageList imageList1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}