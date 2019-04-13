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
    public partial class frmManterFunc : Form
    {
        private string codUsuario;
        public frmManterFunc( string codUsuario2)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuDiretor menu = new frmMenuDiretor(codUsuario);
            this.Hide();
            menu.Show();
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmCadastrarFunc(codUsuario));
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEditarFunc());
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirFunc());
        }

        private void btnVerFunc_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmVerFunc());
        }
    }

   
}
