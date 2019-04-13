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
    public partial class frmMenuSecretaria : Form
    {
        string cod;
        public frmMenuSecretaria(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmManterAluno aluno = new frmManterAluno(cod);
            this.Hide();
            aluno.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLoginSecretaria login = new frmLoginSecretaria();
            this.Hide();
            login.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            frmManterTurma turma = new frmManterTurma(cod);
            this.Hide();
            turma.Show();
        }

        private void btnEmitirRelatorioFrequencia_Click(object sender, EventArgs e)
        {
            frmRelatorioAluno relatorioAluno = new frmRelatorioAluno();
            this.Hide();
            relatorioAluno.Show();
        }

        private void btnBoletim_Click(object sender, EventArgs e)
        {
            frmBoletim boletim = new frmBoletim();
            this.Hide();
            boletim.Show();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            frmCertificadoMatricula certificadoMatricula = new frmCertificadoMatricula();
            this.Hide();
            certificadoMatricula.Show();
        }

        private void btnCertificadoConclusao_Click(object sender, EventArgs e)
        {
            frmCertificadoConclusao certificadoConclusao = new frmCertificadoConclusao();
            this.Hide();
            certificadoConclusao.Show();
        }
    }
}
