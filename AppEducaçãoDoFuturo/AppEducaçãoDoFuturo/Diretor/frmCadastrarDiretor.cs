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
    public partial class frmCadastrarDiretor : Form
    {
        
        public frmCadastrarDiretor()
        {
            InitializeComponent();
        }
        ClassDiretor diretor = new ClassDiretor();

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            diretor.CpfDigitado = mskCpf.Text;
            if (diretor.ValidarCpf() == true)
            {
                mskCpf.ForeColor = Color.Tomato;

            }
            else
            {
                mskCpf.ForeColor = Color.Black;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length <= 3)
            {
                txtNome.ForeColor = Color.Tomato;
            }
            else
            {
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            diretor.EmailDigitado = txtEmail.Text;
            if (diretor.ValidarEmail() == true)
            {
                txtEmail.ForeColor = Color.Tomato;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
            }
        }

        public bool Validar()
        {
            if (mskCpf.ForeColor == Color.Tomato)
            {
                MessageBox.Show("CPF inválido.");
                return false;
            }
            if (txtNome.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Nome inválido.");
                return false;
            }
           
            if (txtEmail.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Email inválido.");
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string dataNasSemMascara = mskDataNas.Text.Replace("/", "");
            string cpfSemMascara = mskCpf.Text.Replace(".", "");

            if ((mskCpf.Text != "") && (txtNome.Text != "") && (txtEmail.Text != "") && (mskDataNas.Text != "") && (mskTelefone.Text != "") && (txtUsuario.Text !="") && (txtSenha.Text !=""))
            {

                if (Validar() == true)
                {

                    diretor.Nome = txtNome.Text;
                    diretor.Telefone = telefoneSemMascara;
                    diretor.Cpf = cpfSemMascara;
                    diretor.Email = txtEmail.Text;
                    diretor.DataNasc = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    diretor.Usuario = txtUsuario.Text;
                    diretor.Senha = txtSenha.Text;
                    DataTable dt = diretor.RetDiretor();

                    string codigoDiretor = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codDiretor"].ToString().Replace("DIR", "") : "0";
                    codigoDiretor = "DIR" + (int.Parse(codigoDiretor) + 1).ToString().PadLeft(3, '0');
                    diretor.CodDiretor = codigoDiretor;


                    if (diretor.InserirDiretor() == true)
                    {
                        MessageBox.Show("Registro concluido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Registro não concluido.");
                    }

                }
                else
                {
                    MessageBox.Show("Registro não concluido.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados.");

            }
        }
    }
}
