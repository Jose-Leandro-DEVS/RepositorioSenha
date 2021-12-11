using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using canto = RepositorioSenha.RoundRect;

namespace RepositorioSenha
{
    public partial class FrmLogin : Form
    {
       

        public FrmLogin()

        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(canto.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        #region Variáveis.
 
        public string Usuario;
        public string Senha;
        public static bool Usuario_E_Senha;
        private string CaminhoDoBancoDeDados = Application.StartupPath.ToString();

        #endregion

        private bool Pesquisar()
        {
            try
            {
                string sql = "SELECT [Usuario],[Senha] FROM [Cadastro] WHERE Usuario = '" + this.TxtUsuario.Text + "' and  Senha = '" + this.TxtSenha.Text + "'" ;
                string sData = "Data source = " + CaminhoDoBancoDeDados + @"\RepositorioSenha.sdf";
                using (SqlCeConnection cn = new SqlCeConnection(sData))
                {
                    cn.Open();
                    SqlCeCommand cm = new SqlCeCommand(sql, cn);

                    SqlCeDataReader dr;
                    dr = cm.ExecuteReader();

                    while (dr.Read())
                    {
                        this.Usuario = dr["Usuario"].ToString();
                        this.Senha = dr["Senha"].ToString();
                        Usuario_E_Senha = true;
                        return true;
                    }
                }
                Usuario_E_Senha = false;
                return false;
            }
            catch
            {
                Usuario_E_Senha = false;
                return false;
            }
        }

        private void LlbCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro RepositorioSenha = new FrmCadastro();
            RepositorioSenha.ShowDialog();
        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            if (Pesquisar())
            {
                this.Close();

            }
            else
            {
                DialogResult r = (MessageBox.Show("Usuário não cadastrado, deseja cadastrar?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (r == DialogResult.Yes) { 
                    LlbCadastro.Enabled = true;
                this.Visible = true; }
                else
                    this.Visible=false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
