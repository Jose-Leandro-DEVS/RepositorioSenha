using System;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepositorioSenha
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            PbSplash.Value = 0;
            PbSplash.Maximum = 100;
            PbSplash.Minimum = 0;
            PbSplash.Visible = true;

            this.TopMost = true;
            this.Visible = true;
            this.Refresh();

            Thread.Sleep(100);
            
            for(int i = 0;i<100;i++)
            {
                PbSplash.Increment(1);
                Thread.Sleep(25);
                this.Refresh();
            }

            PbSplash.Value = 0;
            PbSplash.Visible = false;

            Thread.Sleep(1000); // Este thread define, quanto tempo o formulário ficará visível.
            this.Close();

        }
    }
}
