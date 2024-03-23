﻿namespace SalSystem.Views
{
    partial class F_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            BtnLogin = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.HighlightText;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 14F);
            txtUsuario.Location = new Point(231, 313);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(238, 25);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.HighlightText;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtSenha.Location = new Point(231, 371);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(238, 25);
            txtSenha.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Transparent;
            BtnLogin.BackgroundImageLayout = ImageLayout.None;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.ForeColor = Color.Transparent;
            BtnLogin.Image = Properties.Resources.login;
            BtnLogin.Location = new Point(189, 449);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(288, 50);
            BtnLogin.TabIndex = 3;
            BtnLogin.TextAlign = ContentAlignment.MiddleLeft;
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ControlDark;
            checkBox1.Location = new Point(189, 421);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lembre-me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(671, 678);
            Controls.Add(checkBox1);
            Controls.Add(BtnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += F_Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button BtnLogin;
        private CheckBox checkBox1;
    }
}