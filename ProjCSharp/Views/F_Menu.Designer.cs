﻿namespace ProjCSharp
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
            fecharToolStripMenuItem = new ToolStripMenuItem();
            panel_Menu = new Panel();
            BtnPagamentos = new Button();
            imageListIcons = new ImageList(components);
            BtnSair = new Button();
            BtnClientes = new Button();
            panel_Rodape = new Panel();
            labelVersao = new Label();
            pictureBackground = new PictureBox();
            menuStrip1.SuspendLayout();
            panel_Menu.SuspendLayout();
            panel_Rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackground).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, atualizaçõesToolStripMenuItem, ajudaToolStripMenuItem, fecharToolStripMenuItem });
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
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(56, 20);
            fecharToolStripMenuItem.Text = "Fechar";
            // 
            // panel_Menu
            // 
            panel_Menu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Menu.Controls.Add(BtnPagamentos);
            panel_Menu.Controls.Add(BtnSair);
            panel_Menu.Controls.Add(BtnClientes);
            panel_Menu.Location = new Point(0, 27);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(1264, 70);
            panel_Menu.TabIndex = 1;
            // 
            // BtnPagamentos
            // 
            BtnPagamentos.ImageIndex = 16;
            BtnPagamentos.ImageList = imageListIcons;
            BtnPagamentos.Location = new Point(102, 10);
            BtnPagamentos.Name = "BtnPagamentos";
            BtnPagamentos.Size = new Size(80, 50);
            BtnPagamentos.TabIndex = 2;
            BtnPagamentos.UseVisualStyleBackColor = true;
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
            // BtnSair
            // 
            BtnSair.ImageIndex = 2;
            BtnSair.ImageList = imageListIcons;
            BtnSair.Location = new Point(188, 10);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(80, 50);
            BtnSair.TabIndex = 1;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.Cursor = Cursors.Hand;
            BtnClientes.ImageIndex = 5;
            BtnClientes.ImageList = imageListIcons;
            BtnClientes.Location = new Point(16, 10);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(80, 50);
            BtnClientes.TabIndex = 0;
            BtnClientes.UseVisualStyleBackColor = true;
            // 
            // panel_Rodape
            // 
            panel_Rodape.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Rodape.Controls.Add(labelVersao);
            panel_Rodape.Location = new Point(0, 648);
            panel_Rodape.Name = "panel_Rodape";
            panel_Rodape.Size = new Size(1264, 35);
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
            pictureBackground.Location = new Point(0, 93);
            pictureBackground.Name = "pictureBackground";
            pictureBackground.Size = new Size(1280, 580);
            pictureBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBackground.TabIndex = 3;
            pictureBackground.TabStop = false;
            // 
            // F_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel_Rodape);
            Controls.Add(panel_Menu);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBackground);
            MainMenuStrip = menuStrip1;
            Name = "F_Menu";
            Text = "Menu [Sistema de Vendas]";
            Load += F_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_Menu.ResumeLayout(false);
            panel_Rodape.ResumeLayout(false);
            panel_Rodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem atualizaçõesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private Panel panel_Menu;
        private Panel panel_Rodape;
        private Button BtnClientes;
        private ImageList imageListIcons;
        private Button BtnPagamentos;
        private Button BtnSair;
        private PictureBox pictureBackground;
        private Label labelVersao;
    }
}