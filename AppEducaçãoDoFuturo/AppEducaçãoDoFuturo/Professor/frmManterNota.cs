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
    public partial class frmManterNota : Form
    {
        string cod;
        public frmManterNota(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuProf prof = new frmMenuProf(cod);
            this.Hide();
            prof.Show();
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
            AbrirFormPanel(new frmInserirNota(cod));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEditarNota());
        }
    }
}
