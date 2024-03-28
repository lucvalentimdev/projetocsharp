namespace SalSystem
{
    partial class F_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Menu));
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            atualizaçõesToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            FecharToolStripMenuItem = new ToolStripMenuItem();
            imageListIcons = new ImageList(components);
            panel_Rodape = new Panel();
            labelVersao = new Label();
            BtnSair = new Button();
            BtnPagamentos = new Button();
            BtnClientes = new Button();
            transparentPanel1 = new Views.Utils.TransparentPanel();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            panel_Rodape.SuspendLayout();
            transparentPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, atualizaçõesToolStripMenuItem, ajudaToolStripMenuItem, FecharToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1152, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(63, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(95, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // atualizaçõesToolStripMenuItem
            // 
            atualizaçõesToolStripMenuItem.Name = "atualizaçõesToolStripMenuItem";
            atualizaçõesToolStripMenuItem.Size = new Size(88, 20);
            atualizaçõesToolStripMenuItem.Text = "Atualizações";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // FecharToolStripMenuItem
            // 
            FecharToolStripMenuItem.Name = "FecharToolStripMenuItem";
            FecharToolStripMenuItem.Size = new Size(56, 20);
            FecharToolStripMenuItem.Text = "Fechar";
            FecharToolStripMenuItem.Click += FecharToolStripMenuItem_Click;
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "client.png");
            imageListIcons.Images.SetKeyName(1, "cadastrar.png");
            imageListIcons.Images.SetKeyName(2, "vendas.png");
            imageListIcons.Images.SetKeyName(3, "sair.png");
            // 
            // panel_Rodape
            // 
            panel_Rodape.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Rodape.BackColor = Color.Gainsboro;
            panel_Rodape.Controls.Add(labelVersao);
            panel_Rodape.Location = new Point(0, 743);
            panel_Rodape.Name = "panel_Rodape";
            panel_Rodape.Size = new Size(1164, 20);
            panel_Rodape.TabIndex = 2;
            // 
            // labelVersao
            // 
            labelVersao.AutoSize = true;
            labelVersao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelVersao.ForeColor = Color.IndianRed;
            labelVersao.Location = new Point(16, 4);
            labelVersao.Name = "labelVersao";
            labelVersao.Size = new Size(67, 15);
            labelVersao.TabIndex = 0;
            labelVersao.Text = "Versão: 1.0";
            // 
            // BtnSair
            // 
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.IndianRed;
            BtnSair.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSair.ImageIndex = 3;
            BtnSair.ImageList = imageListIcons;
            BtnSair.Location = new Point(8, 183);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(110, 50);
            BtnSair.TabIndex = 3;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnPagamentos
            // 
            BtnPagamentos.Cursor = Cursors.Hand;
            BtnPagamentos.FlatStyle = FlatStyle.Flat;
            BtnPagamentos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPagamentos.ForeColor = Color.IndianRed;
            BtnPagamentos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPagamentos.ImageIndex = 2;
            BtnPagamentos.ImageList = imageListIcons;
            BtnPagamentos.Location = new Point(8, 127);
            BtnPagamentos.Name = "BtnPagamentos";
            BtnPagamentos.Size = new Size(110, 50);
            BtnPagamentos.TabIndex = 2;
            BtnPagamentos.Text = "Vender";
            BtnPagamentos.TextAlign = ContentAlignment.MiddleRight;
            BtnPagamentos.UseVisualStyleBackColor = true;
            BtnPagamentos.Click += BtnPagamentos_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.Cursor = Cursors.Hand;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClientes.ForeColor = Color.IndianRed;
            BtnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClientes.ImageIndex = 0;
            BtnClientes.ImageList = imageListIcons;
            BtnClientes.Location = new Point(8, 15);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(110, 50);
            BtnClientes.TabIndex = 0;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.MiddleRight;
            BtnClientes.UseVisualStyleBackColor = true;
            // 
            // transparentPanel1
            // 
            transparentPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            transparentPanel1.BackColor = Color.Transparent;
            transparentPanel1.Controls.Add(button1);
            transparentPanel1.Controls.Add(BtnClientes);
            transparentPanel1.Controls.Add(BtnSair);
            transparentPanel1.Controls.Add(BtnPagamentos);
            transparentPanel1.Location = new Point(-2, 24);
            transparentPanel1.Name = "transparentPanel1";
            transparentPanel1.Size = new Size(129, 704);
            transparentPanel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.IndianRed;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = imageListIcons;
            button1.Location = new Point(8, 71);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 1;
            button1.Text = "Cád.Prods";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // F_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1152, 761);
            Controls.Add(transparentPanel1);
            Controls.Add(panel_Rodape);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "F_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu [Sistema de Vendas]";
            Load += F_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_Rodape.ResumeLayout(false);
            panel_Rodape.PerformLayout();
            transparentPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem atualizaçõesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem FecharToolStripMenuItem;
        private Panel panel_Rodape;
        private ImageList imageListIcons;
        private Label labelVersao;
        private Button BtnSair;
        private Button BtnPagamentos;
        private Button BtnClientes;
        private Views.Utils.TransparentPanel transparentPanel1;
        private Button button1;
    }
}
