namespace RepositorioSenha
{
    partial class FrmCadastro
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmailDeReferencia = new System.Windows.Forms.TextBox();
            this.txtEmailDeRecuperacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPerguntaDeSeguranca = new System.Windows.Forms.TextBox();
            this.txtRespostaDaPergunta = new System.Windows.Forms.TextBox();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskCelular = new System.Windows.Forms.MaskedTextBox();
            this.TxtIdRepositorio = new System.Windows.Forms.TextBox();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 100);
            this.panel1.TabIndex = 5;
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
            this.LblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseDown);
            this.LblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseMove);
            this.LblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblTitulo_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email de Referência:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email de Recuperação:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(171, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "José Mendes";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(277, 161);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(94, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "123456";
            // 
            // txtEmailDeReferencia
            // 
            this.txtEmailDeReferencia.Location = new System.Drawing.Point(171, 199);
            this.txtEmailDeReferencia.Name = "txtEmailDeReferencia";
            this.txtEmailDeReferencia.Size = new System.Drawing.Size(200, 20);
            this.txtEmailDeReferencia.TabIndex = 2;
            this.txtEmailDeReferencia.Text = "josemendess09@gmail.com";
            // 
            // txtEmailDeRecuperacao
            // 
            this.txtEmailDeRecuperacao.Location = new System.Drawing.Point(171, 239);
            this.txtEmailDeRecuperacao.Name = "txtEmailDeRecuperacao";
            this.txtEmailDeRecuperacao.Size = new System.Drawing.Size(200, 20);
            this.txtEmailDeRecuperacao.TabIndex = 3;
            this.txtEmailDeRecuperacao.Tag = "";
            this.txtEmailDeRecuperacao.Text = "josemendess09@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "2 - Qual a sua cidade natal:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "3 - Em que ano sua mãe nasceu:";
            this.label9.Visible = false;
            // 
            // txtPerguntaDeSeguranca
            // 
            this.txtPerguntaDeSeguranca.Location = new System.Drawing.Point(171, 340);
            this.txtPerguntaDeSeguranca.Multiline = true;
            this.txtPerguntaDeSeguranca.Name = "txtPerguntaDeSeguranca";
            this.txtPerguntaDeSeguranca.Size = new System.Drawing.Size(200, 98);
            this.txtPerguntaDeSeguranca.TabIndex = 5;
            this.txtPerguntaDeSeguranca.Text = "teste";
            // 
            // txtRespostaDaPergunta
            // 
            this.txtRespostaDaPergunta.Location = new System.Drawing.Point(171, 464);
            this.txtRespostaDaPergunta.Name = "txtRespostaDaPergunta";
            this.txtRespostaDaPergunta.Size = new System.Drawing.Size(200, 20);
            this.txtRespostaDaPergunta.TabIndex = 6;
            this.txtRespostaDaPergunta.Text = "testando";
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(280, 506);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir.TabIndex = 9;
            this.Btn_Excluir.Text = "Ecxluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Location = new System.Drawing.Point(381, 506);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fechar.TabIndex = 10;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Resposta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "1 - Qual é o seu animal de estimação:";
            this.label11.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pergunta de Segurança:";
            // 
            // MskCelular
            // 
            this.MskCelular.Location = new System.Drawing.Point(277, 288);
            this.MskCelular.Mask = "(##)#####-####";
            this.MskCelular.Name = "MskCelular";
            this.MskCelular.Size = new System.Drawing.Size(94, 20);
            this.MskCelular.TabIndex = 4;
            this.MskCelular.Text = "11962973604";
            this.MskCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtIdRepositorio
            // 
            this.TxtIdRepositorio.Location = new System.Drawing.Point(171, 124);
            this.TxtIdRepositorio.Name = "TxtIdRepositorio";
            this.TxtIdRepositorio.Size = new System.Drawing.Size(200, 20);
            this.TxtIdRepositorio.TabIndex = 12;
            this.TxtIdRepositorio.Visible = false;
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Location = new System.Drawing.Point(185, 506);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Atualizar.TabIndex = 11;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(88, 506);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 7;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(185, 506);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 15;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Location = new System.Drawing.Point(373, 124);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(75, 20);
            this.Btn_Pesquisar.TabIndex = 16;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 551);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.MskCelular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.txtRespostaDaPergunta);
            this.Controls.Add(this.txtPerguntaDeSeguranca);
            this.Controls.Add(this.txtEmailDeRecuperacao);
            this.Controls.Add(this.txtEmailDeReferencia);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtIdRepositorio);
            this.Controls.Add(this.Btn_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmailDeReferencia;
        private System.Windows.Forms.TextBox txtEmailDeRecuperacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPerguntaDeSeguranca;
        private System.Windows.Forms.TextBox txtRespostaDaPergunta;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskCelular;
        private System.Windows.Forms.TextBox TxtIdRepositorio;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn_Pesquisar;
    }
}