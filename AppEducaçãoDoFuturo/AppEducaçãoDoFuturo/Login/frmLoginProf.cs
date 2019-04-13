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
    public partial class frmLoginProf : Form
    { 
        public frmLoginProf()
        {
            InitializeComponent();
        }

        ClassProfessor prof = new ClassProfessor();
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEntrada entrada = new frmEntrada();
            this.Hide();
            entrada.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            prof.Usuario = txtLogin.Text;
            prof.Senha = txtSenha.Text;

            DataTable dt = prof.RealizarLogin();

            // saber se foram retornados registros do select
            if (dt.Rows.Count > 0)
            {
                //Como usar os dados desta tabela
                string loginProf = dt.Rows[0]["usuario"].ToString();
                string cod = dt.Rows[0]["codProfessor"].ToString();

                frmMenuProf menu = new frmMenuProf(cod);
                this.Hide();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Login e senha errados. Tente novamente.");
            }
           
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '•';
        }
    }
}
