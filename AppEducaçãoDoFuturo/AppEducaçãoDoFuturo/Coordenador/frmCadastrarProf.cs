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
    public partial class frmCadastrarProf : Form
    {
        string cod;
        public frmCadastrarProf(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }

        ClassProfessor prof = new ClassProfessor();
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

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            prof.CpfDigitado = mskCpf.Text;
            if (prof.ValidarCpf() == true)
            {
                mskCpf.ForeColor = Color.Tomato;
            }
            else
            {
                mskCpf.ForeColor = Color.Black;

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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            prof.EmailDigitado = txtEmail.Text;
            if (prof.ValidarEmail() == true)
            {
                txtEmail.ForeColor = Color.Tomato;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;

            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.Black;
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

            if ((cpfSemMascara != "") && (txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") && (dataNasSemMascara != ""))
            {
                if (Validar() == true)
                {

                    prof.Nome = txtNome.Text;
                    prof.Telefone = telefoneSemMascara;
                    prof.Email = txtEmail.Text;
                    prof.DataNasc = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    prof.Cpf = cpfSemMascara;
                    DataTable dt = prof.RetProfessor();
                    string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codProfessor"].ToString().Replace("PROF", "") : "0";
                    codigo = "PROF" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                    prof.CodProfessor = codigo;
                    prof.Usuario = txtUsuario.Text;
                    prof.Senha = txtSenha.Text;
                    prof.DataCadastro = DateTime.Now.ToString("yyyy/MM/dd");


                    if (prof.InserirProfessor(cod) == true)
                    {
                        MessageBox.Show("Registro concluido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Registro não concluido.Tente novamente.");
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
