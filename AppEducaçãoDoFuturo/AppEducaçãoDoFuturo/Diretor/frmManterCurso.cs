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
    public partial class frmManterCurso : Form
    {
        string codUsuario;
        public frmManterCurso(string codUsuario2)
        {
            codUsuario = codUsuario2;
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

        private void frmManterCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuDiretor menu = new frmMenuDiretor(codUsuario);
            this.Hide();
            menu.Show();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmCadastrarCurso(codUsuario));

        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEditarCurso());
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirCurso());
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmVerCursos());
        }
    }
}
