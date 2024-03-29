namespace SalSystem.Views
{
    partial class F_CadClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CadClientes));
            transparentPanel1 = new Utils.TransparentPanel();
            BtnAdicionar = new Button();
            imageListIcons = new ImageList(components);
            BtnConfirmar = new Button();
            BtnConsultar = new Button();
            BtnCancelar = new Button();
            BtnFechar = new Button();
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
            transparentPanel1.Location = new Point(0, 486);
            transparentPanel1.Name = "transparentPanel1";
            transparentPanel1.Size = new Size(944, 57);
            transparentPanel1.TabIndex = 1;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.FlatStyle = FlatStyle.Flat;
            BtnAdicionar.ForeColor = Color.LimeGreen;
            BtnAdicionar.ImageIndex = 4;
            BtnAdicionar.ImageList = imageListIcons;
            BtnAdicionar.Location = new Point(262, 8);
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
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.ForeColor = Color.LimeGreen;
            BtnConfirmar.ImageIndex = 3;
            BtnConfirmar.ImageList = imageListIcons;
            BtnConfirmar.Location = new Point(338, 8);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(70, 40);
            BtnConfirmar.TabIndex = 4;
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.ForeColor = Color.DodgerBlue;
            BtnConsultar.ImageIndex = 1;
            BtnConsultar.ImageList = imageListIcons;
            BtnConsultar.Location = new Point(414, 8);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(70, 40);
            BtnConsultar.TabIndex = 3;
            BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Transparent;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.ForeColor = Color.DarkRed;
            BtnCancelar.ImageIndex = 0;
            BtnCancelar.ImageList = imageListIcons;
            BtnCancelar.Location = new Point(490, 8);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(70, 40);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.BackgroundImageLayout = ImageLayout.Center;
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.ForeColor = Color.DarkRed;
            BtnFechar.ImageIndex = 5;
            BtnFechar.ImageList = imageListIcons;
            BtnFechar.Location = new Point(566, 8);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.RightToLeft = RightToLeft.No;
            BtnFechar.Size = new Size(70, 40);
            BtnFechar.TabIndex = 1;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // F_CadClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 543);
            ControlBox = false;
            Controls.Add(transparentPanel1);
            DoubleBuffered = true;
            Name = "F_CadClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Clientes";
            transparentPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Utils.TransparentPanel transparentPanel1;
        private Button BtnFechar;
        private ImageList imageListIcons;
        private Button BtnCancelar;
        private Button BtnConfirmar;
        private Button BtnConsultar;
        private Button BtnAdicionar;
    }
}