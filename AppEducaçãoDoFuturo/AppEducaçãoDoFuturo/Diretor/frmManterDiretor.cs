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
    public partial class frmManterDiretor : Form
    {
        string cod;
        public frmManterDiretor(string cod2)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmCadastrarDiretor());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuDiretor menu = new frmMenuDiretor(cod);
            this.Hide();
            menu.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEditarDiretor());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirDiretor());
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmVerDiretor());
        }
    }
}
