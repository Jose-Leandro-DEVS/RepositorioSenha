using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace RepositorioSenha
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        #region Variáveis.

        private string CaminhoDoBancoDeDados = Application.StartupPath.ToString();

        readonly List<SqlCeParameter> parametros = new List<SqlCeParameter>();
        private bool MoverFormulario = false;

        #endregion

        #region Enumeradores.

        private enum OqueFazer { cadastrar, atualizar, excluir }

        #endregion

        #region Atributos.

        private string _Id_Repositorio;
        private string _Usuario;
        private string _Senha;
        private string _Email_Referencia;
        private string _Email_Recuperaca;
        private string _Celular;
        private string _PerguntaDeSeguranca;
        private string _RespostaDaPergunta;
        private DateTime _DataCadastro;

        #endregion

        #region Propriedades

        private string Id_Repositorio
        {
            get { return _Id_Repositorio; }
            set { _Id_Repositorio = value; }
        }

        private string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        private string Email_Referencia
        {
            get { return _Email_Referencia; }
            set { _Email_Referencia = value; }
        }

        private string Email_Recuperaca
        {
            get { return _Email_Recuperaca; }
            set { _Email_Recuperaca = value; }
        }

        private string Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }

        private string PerguntaDeSeguranca
        {
            get { return _PerguntaDeSeguranca; }
            set { _PerguntaDeSeguranca = value; }
        }

        private string RespostaDaPergunta
        {
            get { return _RespostaDaPergunta; }
            set { _RespostaDaPergunta = value; }
        }

        private DateTime DataCadastro
        {
            get { return _DataCadastro; }
            set { _DataCadastro = value; }
        }

        #endregion

        #region Métodos.

        private void Limpar()
        {
            this.txtUsuario.Clear();
            this.txtSenha.Clear();
            this.txtEmailDeRecuperacao.Clear();
            this.txtEmailDeReferencia.Clear();
            this.txtPerguntaDeSeguranca.Clear();
            this.txtRespostaDaPergunta.Clear();
            this.TxtIdRepositorio.Clear();
            this.MskCelular.Clear();
        }

        private bool ValidarDados(OqueFazer oQueFazer)
        {
         if (this.TxtIdRepositorio.Text == string.Empty & oQueFazer != OqueFazer.excluir) { MessageBox.Show("Selecione um registro para excluir.", Application.ProductName, MessageBoxButtons.OK); return false; }
               if (this.txtUsuario.Text == string.Empty | this.txtSenha.Text == string.Empty | this.txtEmailDeRecuperacao.Text == string.Empty | this.txtEmailDeReferencia.Text == string.Empty | this.MskCelular.Text == string.Empty | this.txtPerguntaDeSeguranca.Text == string.Empty | this.txtRespostaDaPergunta.Text == string.Empty) { return false; }
                    this.Id_Repositorio = this.TxtIdRepositorio.Text.Trim();
                           this.Usuario = this.txtUsuario.Text.Trim();
                             this.Senha = this.txtSenha.Text.Trim();
                  this.Email_Recuperaca = this.txtEmailDeRecuperacao.Text.Trim();
                  this.Email_Referencia = this.txtEmailDeReferencia.Text.Trim();
                           this.Celular = this.MskCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
               this.PerguntaDeSeguranca = this.txtPerguntaDeSeguranca.Text.Trim();
                this.RespostaDaPergunta = this.txtRespostaDaPergunta.Text.Trim();
                      this.DataCadastro = DateTime.Now;
               return true;
        }

        private bool ExecutarQuery(string Sql, OqueFazer oQueFazer)
        {
            try
            {
                if (!ValidarDados(oQueFazer)) { MessageBox.Show("Todos os campos são obrigatórios, por favor, preencha todos os campos.", Application.ProductName, MessageBoxButtons.OK); return false; }
                AdicionarParametros(oQueFazer);
                string sData = "Data source = " + CaminhoDoBancoDeDados + @"\RepositorioSenha.sdf";
                using (SqlCeConnection cn = new SqlCeConnection(sData))
                {
                    cn.Open();
                    SqlCeCommand cm = new SqlCeCommand(Sql, cn);
 
                    foreach(SqlCeParameter p in parametros)
                    {
                        cm.Parameters.Add(p);
                    }
                    
                    cm.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void TratarBotoes(bool t)
        {
            this.Btn_Cancelar.Visible = !t;
            this.Btn_Atualizar.Visible =  t;
            this.Btn_Excluir.Enabled = t;
            this.Btn_Fechar.Enabled = t;
        }

        private bool Pesquisar(string Filtro)
        {
            try
            {
                string sql = "SELECT [Id_Repositorio],[Usuario],[Senha],[Email_Referencia],[Email_Recuperaca],[Celular],[PerguntaDeSeguranca],[RespostaDaPergunta],[DataCadastro] FROM[Cadastro] WHERE Usuario = '" + Filtro + "'";
                string sData = "Data source = " + CaminhoDoBancoDeDados + @"\RepositorioSenha.sdf";
                using (SqlCeConnection cn = new SqlCeConnection(sData))
                {
                    cn.Open();
                    SqlCeCommand cm = new SqlCeCommand(sql, cn);

                    SqlCeDataReader dr;
                    dr = cm.ExecuteReader();

                    while(dr.Read())
                    {
                           this.Id_Repositorio = dr["Id_Repositorio"].ToString();
                                  this.Usuario = dr["Usuario"].ToString();
                                    this.Senha = dr["Senha"].ToString();
                         this.Email_Referencia = dr["Email_Referencia"].ToString();
                         this.Email_Recuperaca = dr["Email_Recuperaca"].ToString();
                                  this.Celular = dr["Celular"].ToString();
                      this.PerguntaDeSeguranca = dr["PerguntaDeSeguranca"].ToString();
                       this.RespostaDaPergunta = dr["RespostaDaPergunta"].ToString();
                             this.DataCadastro = DateTime.Parse(dr["DataCadastro"].ToString());

                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Métodos do formulário.

        private void AdicionarParametros(OqueFazer oqueFazer)
        {
            parametros.Clear();
            SqlCeParameter novoPar = new SqlCeParameter("@Id_Repositorio", this.Id_Repositorio);
            parametros.Add(novoPar);
            if (oqueFazer == OqueFazer.cadastrar) parametros.Clear();
            novoPar = new SqlCeParameter("@Usuario", this.Usuario);
            parametros.Add(novoPar);
            novoPar = new SqlCeParameter("@Senha", this.Senha);
            parametros.Add(novoPar);
            novoPar = new SqlCeParameter("@Email_Referencia", this.Email_Referencia);
            parametros.Add(novoPar);
            novoPar = new SqlCeParameter("@Email_Recuperaca", this.Email_Recuperaca);
            parametros.Add(novoPar);
            novoPar = new SqlCeParameter("@Celular", this.Celular);
            parametros.Add(novoPar);
            novoPar = new SqlCeParameter("@PerguntaDeSeguranca", this.PerguntaDeSeguranca);
            parametros.Add(novoPar);
            novoPar = new SqlCeParameter("@RespostaDaPergunta", this.RespostaDaPergunta);
            parametros.Add(novoPar);
            novoPar = new SqlCeParameter("@DataCadastro", this.DataCadastro);
            parametros.Add(novoPar);
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM [Cadastro] WHERE Id_Repositorio = @Id_Repositorio";

            if (this.ExecutarQuery(sql, OqueFazer.excluir) == true)
            {
                MessageBox.Show("Os dados foram excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir os cadastro");
            }

        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            string sql = "  UPDATE[Cadastro]";
                   sql += " SET Usuario = @Usuario";
                   sql += ",Senha = @Senha";
                   sql += ",Email_Referencia = @Email_Referencia";
                   sql += ",Email_Recuperaca = @Email_Recuperaca";
                   sql += ",Celular = @Celular";
                   sql += ",PerguntaDeSeguranca = @PerguntaDeSeguranca";
                   sql += ",RespostaDaPergunta = @RespostaDaPergunta";
                   sql += ",DataCadastro = @DataCadastro";
                   sql += " WHERE Id_Repositorio = @Id_Repositorio";

            if (this.ExecutarQuery(sql, OqueFazer.atualizar) == true)
            {
                MessageBox.Show("Os dados foram atualizados com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar os cadastro");
            }
                this.TratarBotoes(true);
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            if (this.Btn_Novo.Text == "Novo")
            {
                this.Btn_Novo.Text = "Gravar";
                this.TratarBotoes(false);
                this.TxtIdRepositorio.Text="-1";
                this.txtUsuario.Focus();
            }
            else
            {
                string sql = "INSERT INTO [Cadastro](Usuario,Senha,Email_Referencia,Email_Recuperaca,Celular,PerguntaDeSeguranca,RespostaDaPergunta,DataCadastro) VALUES (@Usuario,@Senha,@Email_Referencia,@Email_Recuperaca,@Celular,@PerguntaDeSeguranca,@RespostaDaPergunta,@DataCadastro)";
                if (this.ExecutarQuery(sql, OqueFazer.cadastrar) == true)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro");
                }
                this.TratarBotoes(true);
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
            GC.Collect();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (this.Btn_Novo.Text == "Gravar")
                this.Btn_Novo.Text = "Novo";
            this.TratarBotoes(true);
        }

        private void LblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
           Cursor = Cursors.Hand;
            MoverFormulario = true;
        }

        private void LblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            MoverFormulario = false;
        }

        private void LblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Cursor.Position.X; //- this.Left;
            int y = Cursor.Position.Y; //- this.Top;

            if (MoverFormulario)
            {
                this.Left = x;
                this.Top = y;
                return;
            }
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(LblTitulo, "Segure e arraste para mover o formulário.");
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (!Pesquisar(this.txtUsuario.Text))
            { MessageBox.Show("Usuário não cadastrado."); Limpar(); }
            else
            {
                Limpar();
                //************************
                this.TxtIdRepositorio.Text = this.Id_Repositorio;
                this.txtUsuario.Text = this.Usuario;
                this.txtSenha.Text = this.Senha;
                this.txtEmailDeReferencia.Text = this.Email_Referencia;
                this.txtEmailDeRecuperacao.Text = this.Email_Recuperaca;
                this.MskCelular.Text = this.Celular;
                this.txtPerguntaDeSeguranca.Text = this.PerguntaDeSeguranca;
                this.txtRespostaDaPergunta.Text = this.RespostaDaPergunta;
            }
        }

        #endregion

    }
}
