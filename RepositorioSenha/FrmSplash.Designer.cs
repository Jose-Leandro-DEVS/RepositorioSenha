namespace RepositorioSenha
{
    partial class FrmSplash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Slogan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PbSplash = new System.Windows.Forms.ProgressBar();
            this.iconCadeado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconCadeado)).BeginInit();
            this.SuspendLayout();
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Slogan.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Slogan.Location = new System.Drawing.Point(67, 371);
            this.Slogan.Name = "Slogan";
            this.Slogan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Slogan.Size = new System.Drawing.Size(436, 64);
            this.Slogan.TabIndex = 0;
            this.Slogan.Text = "Cansado de ter que ficar memorizando varias senha \r\ne acidentalmente\r\n acabar esq" +
    "uecendo \r\nou perdendo de onde tinha salvo.";
            this.Slogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(54, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password Repository";
            // 
            // PbSplash
            // 
            this.PbSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PbSplash.Location = new System.Drawing.Point(0, 585);
            this.PbSplash.Name = "PbSplash";
            this.PbSplash.Size = new System.Drawing.Size(561, 5);
            this.PbSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PbSplash.TabIndex = 3;
            this.PbSplash.Visible = false;
            // 
            // iconCadeado
            // 
            this.iconCadeado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCadeado.Image = global::RepositorioSenha.Properties.Resources.iconCadeado;
            this.iconCadeado.Location = new System.Drawing.Point(185, 96);
            this.iconCadeado.Name = "iconCadeado";
            this.iconCadeado.Size = new System.Drawing.Size(197, 185);
            this.iconCadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCadeado.TabIndex = 2;
            this.iconCadeado.TabStop = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(561, 590);
            this.Controls.Add(this.PbSplash);
            this.Controls.Add(this.iconCadeado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Slogan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconCadeado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox iconCadeado;
        private System.Windows.Forms.ProgressBar PbSplash;
    }
}

