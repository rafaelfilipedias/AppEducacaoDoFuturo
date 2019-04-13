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
    public partial class frmMenuProf : Form
    {
        string cod;
        public frmMenuProf(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLoginProf login = new frmLoginProf();
            this.Hide();
            login.Show();
        }

        private void btnCadastrarFrequencia_Click(object sender, EventArgs e)
        {
            frmManterFrequenciaAluno manter = new frmManterFrequenciaAluno(cod);
            this.Hide();
            manter.Show();

        }

        private void btnCadastrarNotas_Click(object sender, EventArgs e)
        {
            frmManterNota manter = new frmManterNota(cod);
            this.Hide();
            manter.Show();
        }
    }
}
