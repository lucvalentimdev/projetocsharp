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
            BtnConfirmar = new Button();
            BtnConsultar = new Button();
            BtnCancelar = new Button();
            BtnFechar = new Button();
            imageListIcons = new ImageList(components);
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
            // F_CadProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(transparentPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_CadProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_CadProdutos";
            transparentPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Views.Utils.TransparentPanel transparentPanel1;
        private Button BtnAdicionar;
        private Button BtnConfirmar;
        private Button BtnConsultar;
        private Button BtnCancelar;
        private Button BtnFechar;
        private ImageList imageListIcons;
    }
}