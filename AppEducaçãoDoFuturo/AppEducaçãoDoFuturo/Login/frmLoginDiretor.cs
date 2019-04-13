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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        ClassDiretor diretor = new ClassDiretor();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            diretor.Usuario = txtLogin.Text;
            diretor.Senha = txtSenha.Text;

            DataTable dt = diretor.RealizarLogin();

            // saber se foram retornados registros do select
            if (dt.Rows.Count > 0)
            {
                //Como usar os dados desta tabela
                string login = dt.Rows[0]["usuario"].ToString();
                string cod = dt.Rows[0]["codDiretor"].ToString();

                frmMenuDiretor menu = new frmMenuDiretor(cod);
                this.Hide();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Login e senha incorretos. Tente novamente.");
            }

            
        }

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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '•';
        }
    }
}
