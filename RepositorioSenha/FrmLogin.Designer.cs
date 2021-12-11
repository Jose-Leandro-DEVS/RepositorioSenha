namespace RepositorioSenha
{
    partial class FrmLogin
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LlbresgatarSenha = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LlbCadastro = new System.Windows.Forms.LinkLabel();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblUsuario.Location = new System.Drawing.Point(86, 280);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(65, 16);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblSenha.Location = new System.Drawing.Point(96, 332);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(55, 16);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Senha:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.ForeColor = System.Drawing.Color.Green;
            this.TxtUsuario.Location = new System.Drawing.Point(158, 280);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(264, 20);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.Text = "Digite seu E-mail ou Usuario.";
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenha.ForeColor = System.Drawing.Color.Green;
            this.TxtSenha.Location = new System.Drawing.Point(158, 332);
            this.TxtSenha.Multiline = true;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(264, 20);
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.Tag = "";
            this.TxtSenha.Text = "Digite sua senha aqui...";
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 100);
            this.panel1.TabIndex = 4;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Copperplate Gothic Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTitulo.Location = new System.Drawing.Point(45, 30);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(456, 40);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Password Repository";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Digite no minimo 6 caracteres";
            // 
            // LlbresgatarSenha
            // 
            this.LlbresgatarSenha.AutoSize = true;
            this.LlbresgatarSenha.Enabled = false;
            this.LlbresgatarSenha.Location = new System.Drawing.Point(288, 519);
            this.LlbresgatarSenha.Name = "LlbresgatarSenha";
            this.LlbresgatarSenha.Size = new System.Drawing.Size(78, 13);
            this.LlbresgatarSenha.TabIndex = 6;
            this.LlbresgatarSenha.TabStop = true;
            this.LlbresgatarSenha.Text = "CLIQUE AQUI.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Esqueceu Usuario ou Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "A senha deve conter pelo menos uma letra maiuscula e outra minuscula, \r\nalém de c" +
    "aracteres especiais por Ex: ! @ #  .";
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.Location = new System.Drawing.Point(215, 388);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(115, 22);
            this.Btn_Logar.TabIndex = 10;
            this.Btn_Logar.Text = "Logar";
            this.Btn_Logar.UseVisualStyleBackColor = true;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = " Já tem uma conta só LOGAR caso contrario :";
            // 
            // LlbCadastro
            // 
            this.LlbCadastro.AutoSize = true;
            this.LlbCadastro.Enabled = false;
            this.LlbCadastro.Location = new System.Drawing.Point(326, 484);
            this.LlbCadastro.Name = "LlbCadastro";
            this.LlbCadastro.Size = new System.Drawing.Size(85, 13);
            this.LlbCadastro.TabIndex = 11;
            this.LlbCadastro.TabStop = true;
            this.LlbCadastro.Text = "CADASTRA-SE.";
            this.LlbCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbCadastro_LinkClicked);
            // 
            // PicFoto
            // 
            this.PicFoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PicFoto.Image = global::RepositorioSenha.Properties.Resources.contacts_96px;
            this.PicFoto.Location = new System.Drawing.Point(203, 148);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(138, 126);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFoto.TabIndex = 9;
            this.PicFoto.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 551);
            this.Controls.Add(this.LlbCadastro);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LlbresgatarSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LlbresgatarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.Button Btn_Logar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel LlbCadastro;
        private System.Windows.Forms.TextBox TxtUsuario;
    }
}