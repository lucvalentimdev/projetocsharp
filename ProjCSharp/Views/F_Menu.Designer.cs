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
            pictureBackground = new PictureBox();
            BtnSair = new Button();
            BtnPagamentos = new Button();
            BtnClientes = new Button();
            transparentPanel1 = new Views.Utils.TransparentPanel();
            menuStrip1.SuspendLayout();
            panel_Rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackground).BeginInit();
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
            menuStrip1.Size = new Size(1264, 24);
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
            imageListIcons.Images.SetKeyName(0, "add_circle_FILL0_wght400_GRAD0_opsz48.png");
            imageListIcons.Images.SetKeyName(1, "close.png");
            imageListIcons.Images.SetKeyName(2, "logout.png");
            imageListIcons.Images.SetKeyName(3, "money.png");
            imageListIcons.Images.SetKeyName(4, "outline_admin_panel_settings_black_24dp.png");
            imageListIcons.Images.SetKeyName(5, "outline_assignment_ind_black_24dp.png");
            imageListIcons.Images.SetKeyName(6, "outline_check_circle_black_24dp.png");
            imageListIcons.Images.SetKeyName(7, "outline_delete_outline_black_24dp.png");
            imageListIcons.Images.SetKeyName(8, "outline_edit_off_black_24dp.png");
            imageListIcons.Images.SetKeyName(9, "outline_fingerprint_black_24dp.png");
            imageListIcons.Images.SetKeyName(10, "outline_highlight_off_black_24dp.png");
            imageListIcons.Images.SetKeyName(11, "outline_lock_open_black_24dp.png");
            imageListIcons.Images.SetKeyName(12, "outline_note_add_black_24dp.png");
            imageListIcons.Images.SetKeyName(13, "outline_print_black_24dp.png");
            imageListIcons.Images.SetKeyName(14, "outline_search_black_24dp.png");
            imageListIcons.Images.SetKeyName(15, "outline_view_timeline_black_24dp.png");
            imageListIcons.Images.SetKeyName(16, "payment.png");
            imageListIcons.Images.SetKeyName(17, "payments.png");
            imageListIcons.Images.SetKeyName(18, "profile.png");
            imageListIcons.Images.SetKeyName(19, "refresh.png");
            imageListIcons.Images.SetKeyName(20, "room_preferences.png");
            imageListIcons.Images.SetKeyName(21, "Termo.png");
            imageListIcons.Images.SetKeyName(22, "termo_2.png");
            imageListIcons.Images.SetKeyName(23, "zoom.png");
            // 
            // panel_Rodape
            // 
            panel_Rodape.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Rodape.Controls.Add(labelVersao);
            panel_Rodape.Location = new Point(0, 648);
            panel_Rodape.Name = "panel_Rodape";
            panel_Rodape.Size = new Size(113, 35);
            panel_Rodape.TabIndex = 2;
            // 
            // labelVersao
            // 
            labelVersao.AutoSize = true;
            labelVersao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelVersao.Location = new Point(16, 10);
            labelVersao.Name = "labelVersao";
            labelVersao.Size = new Size(67, 15);
            labelVersao.TabIndex = 0;
            labelVersao.Text = "Versão: 1.0";
            // 
            // pictureBackground
            // 
            pictureBackground.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBackground.Image = Properties.Resources.backgroudjpg;
            pictureBackground.Location = new Point(0, 23);
            pictureBackground.Name = "pictureBackground";
            pictureBackground.Size = new Size(1280, 660);
            pictureBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBackground.TabIndex = 3;
            pictureBackground.TabStop = false;
            // 
            // BtnSair
            // 
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.ForeColor = Color.Transparent;
            BtnSair.ImageIndex = 2;
            BtnSair.ImageList = imageListIcons;
            BtnSair.Location = new Point(12, 136);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(80, 50);
            BtnSair.TabIndex = 4;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnPagamentos
            // 
            BtnPagamentos.FlatStyle = FlatStyle.Flat;
            BtnPagamentos.ForeColor = Color.Transparent;
            BtnPagamentos.ImageIndex = 16;
            BtnPagamentos.ImageList = imageListIcons;
            BtnPagamentos.Location = new Point(12, 80);
            BtnPagamentos.Name = "BtnPagamentos";
            BtnPagamentos.Size = new Size(80, 50);
            BtnPagamentos.TabIndex = 5;
            BtnPagamentos.UseVisualStyleBackColor = true;
            BtnPagamentos.Click += BtnPagamentos_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.Cursor = Cursors.Hand;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.ForeColor = Color.Transparent;
            BtnClientes.ImageIndex = 5;
            BtnClientes.ImageList = imageListIcons;
            BtnClientes.Location = new Point(12, 24);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(80, 50);
            BtnClientes.TabIndex = 6;
            BtnClientes.UseVisualStyleBackColor = true;
            // 
            // transparentPanel1
            // 
            transparentPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            transparentPanel1.BackColor = Color.Transparent;
            transparentPanel1.Controls.Add(BtnClientes);
            transparentPanel1.Controls.Add(BtnSair);
            transparentPanel1.Controls.Add(BtnPagamentos);
            transparentPanel1.Location = new Point(-2, 24);
            transparentPanel1.Name = "transparentPanel1";
            transparentPanel1.Size = new Size(115, 628);
            transparentPanel1.TabIndex = 7;
            // 
            // F_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(transparentPanel1);
            Controls.Add(panel_Rodape);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBackground);
            MainMenuStrip = menuStrip1;
            Name = "F_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu [Sistema de Vendas]";
            Load += F_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_Rodape.ResumeLayout(false);
            panel_Rodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackground).EndInit();
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
        private PictureBox pictureBackground;
        private Label labelVersao;
        private Button BtnSair;
        private Button BtnPagamentos;
        private Button BtnClientes;
        private Views.Utils.TransparentPanel transparentPanel1;
    }
}
