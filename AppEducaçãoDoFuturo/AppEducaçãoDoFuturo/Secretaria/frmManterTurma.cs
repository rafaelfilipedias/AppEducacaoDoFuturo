using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEducaçãoDoFuturo
{
    public partial class frmManterTurma : Form
    {
        string cod;
        public frmManterTurma(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }
        private void AbrirFormPanel(object FormFilho)
        {
            if (this.pnlMostrar.Controls.Count > 0)
                this.pnlMostrar.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlMostrar.Controls.Add(fh);
            this.pnlMostrar.Tag = fh;
            fh.Show();
        }
        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmTurmaCadastrar(cod));
        }

        private void btnEditarTurma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEditarTurma());
        }

        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirTurma());
        }

        private void btnVerTurma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmVerTurmas());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuSecretaria menu = new frmMenuSecretaria(cod);
            this.Hide();
            menu.Show();
        }
    }
}
