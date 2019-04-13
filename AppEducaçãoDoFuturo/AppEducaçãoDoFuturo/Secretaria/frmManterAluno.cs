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
    public partial class frmManterAluno : Form
    {
        string cod;
        public frmManterAluno(string cod2)

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
        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirAluno());
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEditarAluno());
        }

        private void btnVerAlunos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmVerAlunos());
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmCadastrarAluno(cod));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuSecretaria menu = new frmMenuSecretaria(cod);
            this.Hide();
            menu.Show();
        }
    }
}
