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
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnSecretaria_Click(object sender, EventArgs e)
        {
            frmLoginSecretaria login = new frmLoginSecretaria();
            this.Hide();
            login.Show();
        }

        private void btnCoordenador_Click(object sender, EventArgs e)
        {
            frmLoginCoordenador login = new frmLoginCoordenador();
            this.Hide();
            login.Show();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            frmLoginProf login = new frmLoginProf();
            this.Hide();
            login.Show();
        }
    }
}
