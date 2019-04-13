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
    public partial class frmMenuCoordenador : Form
    {
        string cod;
        public frmMenuCoordenador(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            frmManterProf prof = new frmManterProf(cod);
            this.Hide();
            prof.Show();
                
        }

        //private void btnTurma_Click(object sender, EventArgs e)
        //{
        //    frmManterTurma turma = new frmManterTurma(cod);
        //    this.Hide();
        //    turma.Show();
        //}

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLoginCoordenador login = new frmLoginCoordenador();
            this.Hide();
            login.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnFrequenciaProf_Click(object sender, EventArgs e)
        {
            frmManterFrequenciaProf login = new frmManterFrequenciaProf(cod);
            this.Hide();
            login.Show();
        }

        private void btnEmitirRelatorio_Click(object sender, EventArgs e)
        {
            frmFrequenciaProfessor frequenciaProfessor = new frmFrequenciaProfessor();
            this.Hide();
            frequenciaProfessor.Show();
        }
    }
}
