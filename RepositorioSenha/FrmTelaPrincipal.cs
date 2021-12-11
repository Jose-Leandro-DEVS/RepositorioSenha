using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepositorioSenha
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void LblTitulo_DoubleClick(object sender, EventArgs e)
        {
           this.Close();
            this.Dispose();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmSplash fs = new FrmSplash();
            fs.ShowDialog();
            fs.Dispose();

            FrmLogin frmLogin = new FrmLogin();
            this.Visible = false;
            frmLogin.ShowDialog();

            if (FrmLogin.Usuario_E_Senha) this.Visible = true;
            else Application.Exit();

        }
    }
}
