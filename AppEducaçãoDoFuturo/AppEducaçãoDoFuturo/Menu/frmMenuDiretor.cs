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
    public partial class frmMenuDiretor : Form
    {
        string codUsuario;
        public frmMenuDiretor(string codUsuario2)
        {
            codUsuario = codUsuario2;
            InitializeComponent();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmManterFunc manterFunc = new frmManterFunc(codUsuario);
            this.Hide();
            manterFunc.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            frmManterCurso manterCurso = new frmManterCurso(codUsuario);
            this.Hide();
            manterCurso.Show();
        }

        private void btnCoordenador_Click(object sender, EventArgs e)
        {
            frmManterCoordenador manterCoordenador = new frmManterCoordenador(codUsuario);
            this.Hide();
            manterCoordenador.Show();
        }

        private void btnDiretor_Click(object sender, EventArgs e)
        {
            frmManterDiretor manterDiretor = new frmManterDiretor(codUsuario);
            this.Hide();
            manterDiretor.Show();
        }

        private void btnFrequenciaFunc_Click(object sender, EventArgs e)
        {
            frmManterFrequenciaFunc manter = new frmManterFrequenciaFunc(codUsuario);
            this.Hide();
            manter.Show();
        }

        private void btnEmitirRelatorio_Click(object sender, EventArgs e)
        {
            frmFrequenciaFuncionario relatarioFuncionario = new frmFrequenciaFuncionario();
            this.Hide();
            relatarioFuncionario.Show();
        }
    }
}
