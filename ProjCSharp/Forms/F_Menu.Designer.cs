﻿namespace SalSystem
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
            BtnVendas = new Button();
            BtnClientes = new Button();
            transparentPanel1 = new Views.Utils.TransparentPanel();
            btnCaixa = new Button();
            BtnProdutos = new Button();
            menuStrip1.SuspendLayout();
            panel_Rodape.SuspendLayout();
            transparentPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, atualizaçõesToolStripMenuItem, ajudaToolStripMenuItem, FecharToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemaToolStripMenuItem.Image = (Image)resources.GetObject("sistemaToolStripMenuItem.Image");
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(86, 23);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(102, 24);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // atualizaçõesToolStripMenuItem
            // 
            atualizaçõesToolStripMenuItem.Image = (Image)resources.GetObject("atualizaçõesToolStripMenuItem.Image");
            atualizaçõesToolStripMenuItem.Name = "atualizaçõesToolStripMenuItem";
            atualizaçõesToolStripMenuItem.Size = new Size(116, 23);
            atualizaçõesToolStripMenuItem.Text = "Atualizações";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Image = (Image)resources.GetObject("ajudaToolStripMenuItem.Image");
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(73, 23);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // FecharToolStripMenuItem
            // 
            FecharToolStripMenuItem.Image = (Image)resources.GetObject("FecharToolStripMenuItem.Image");
            FecharToolStripMenuItem.Name = "FecharToolStripMenuItem";
            FecharToolStripMenuItem.Size = new Size(88, 23);
            FecharToolStripMenuItem.Text = "Encerrar";
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
            imageListIcons.Images.SetKeyName(4, "finance 32x32.png");
            // 
            // panel_Rodape
            // 
            panel_Rodape.BackColor = Color.Gainsboro;
            panel_Rodape.Controls.Add(labelVersao);
            panel_Rodape.Dock = DockStyle.Bottom;
            panel_Rodape.Location = new Point(0, 741);
            panel_Rodape.Name = "panel_Rodape";
            panel_Rodape.Size = new Size(1264, 20);
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
            BtnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.IndianRed;
            BtnSair.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSair.ImageIndex = 3;
            BtnSair.ImageList = imageListIcons;
            BtnSair.Location = new Point(8, 649);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(100, 50);
            BtnSair.TabIndex = 3;
            BtnSair.Text = "Sair";
            BtnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnVendas
            // 
            BtnVendas.Cursor = Cursors.Hand;
            BtnVendas.FlatAppearance.BorderSize = 0;
            BtnVendas.FlatStyle = FlatStyle.Flat;
            BtnVendas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVendas.ForeColor = Color.IndianRed;
            BtnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVendas.ImageIndex = 2;
            BtnVendas.ImageList = imageListIcons;
            BtnVendas.Location = new Point(8, 127);
            BtnVendas.Name = "BtnVendas";
            BtnVendas.Size = new Size(100, 50);
            BtnVendas.TabIndex = 2;
            BtnVendas.TabStop = false;
            BtnVendas.Text = "Vender";
            BtnVendas.TextAlign = ContentAlignment.MiddleRight;
            BtnVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnVendas.UseVisualStyleBackColor = true;
            BtnVendas.Click += BtnPagamentos_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.Cursor = Cursors.Hand;
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClientes.ForeColor = Color.IndianRed;
            BtnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClientes.ImageIndex = 0;
            BtnClientes.ImageList = imageListIcons;
            BtnClientes.Location = new Point(8, 15);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(100, 50);
            BtnClientes.TabIndex = 0;
            BtnClientes.TabStop = false;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.MiddleRight;
            BtnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // transparentPanel1
            // 
            transparentPanel1.BackColor = Color.Transparent;
            transparentPanel1.Controls.Add(btnCaixa);
            transparentPanel1.Controls.Add(BtnProdutos);
            transparentPanel1.Controls.Add(BtnClientes);
            transparentPanel1.Controls.Add(BtnSair);
            transparentPanel1.Controls.Add(BtnVendas);
            transparentPanel1.Dock = DockStyle.Left;
            transparentPanel1.Location = new Point(0, 27);
            transparentPanel1.Name = "transparentPanel1";
            transparentPanel1.Size = new Size(120, 714);
            transparentPanel1.TabIndex = 7;
            // 
            // btnCaixa
            // 
            btnCaixa.Cursor = Cursors.Hand;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCaixa.ForeColor = Color.IndianRed;
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.ImageIndex = 4;
            btnCaixa.ImageList = imageListIcons;
            btnCaixa.Location = new Point(8, 183);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(100, 50);
            btnCaixa.TabIndex = 4;
            btnCaixa.Text = "Caixa";
            btnCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCaixa.UseVisualStyleBackColor = true;
            btnCaixa.Click += BtnCaixa_Click;
            // 
            // BtnProdutos
            // 
            BtnProdutos.Cursor = Cursors.Hand;
            BtnProdutos.FlatAppearance.BorderSize = 0;
            BtnProdutos.FlatStyle = FlatStyle.Flat;
            BtnProdutos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProdutos.ForeColor = Color.IndianRed;
            BtnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProdutos.ImageIndex = 1;
            BtnProdutos.ImageList = imageListIcons;
            BtnProdutos.Location = new Point(8, 71);
            BtnProdutos.Name = "BtnProdutos";
            BtnProdutos.Size = new Size(100, 50);
            BtnProdutos.TabIndex = 1;
            BtnProdutos.TabStop = false;
            BtnProdutos.Text = "Produto";
            BtnProdutos.TextAlign = ContentAlignment.MiddleRight;
            BtnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProdutos.UseVisualStyleBackColor = true;
            BtnProdutos.Click += BtnProdutos_Click;
            // 
            // F_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 761);
            Controls.Add(transparentPanel1);
            Controls.Add(panel_Rodape);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "F_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalSystem [Menu]";
            Load += F_Menu_Load;
            KeyDown += F_Menu_KeyDown;
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
        private Button BtnVendas;
        private Button BtnClientes;
        private Views.Utils.TransparentPanel transparentPanel1;
        private Button BtnProdutos;
        private Button btnCaixa;
    }
}
