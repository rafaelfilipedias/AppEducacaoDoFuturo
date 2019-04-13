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
    public partial class frmCadastrarAluno : Form
    {
        string cod;
        ClassAluno aluno = new ClassAluno();
        public frmCadastrarAluno(string cod2)
        {
            cod = cod2;
            InitializeComponent();
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

        private void mskDataNas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void mskCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            aluno.CpfDigitado = mskCpf.Text;
            if (aluno.ValidarCpf() == true)
            {
                mskCpf.ForeColor = Color.Red;

            }
            else
            {
                mskCpf.ForeColor = Color.Black;
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
            if (mskTelefone.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Telefone inválido.");
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

            if ((mskCpf.Text != "") && (txtNome.Text != "") && (txtEmail.Text != "") && (mskDataNas.Text != "") && (mskTelefone.Text != ""))
            {

                if (Validar() == true)
                {

                    aluno.Nome = txtNome.Text;
                    aluno.Telefone = telefoneSemMascara;
                    aluno.Cpf = cpfSemMascara;
                    aluno.Email = txtEmail.Text;
                    aluno.DataNasc = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    DataTable dt = aluno.RetAluno();

                    string codigoAluno = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codAluno"].ToString().Replace("ALUN", "") : "0";
                    codigoAluno = "ALUN" + (int.Parse(codigoAluno) + 1).ToString().PadLeft(3, '0');
                    aluno.CodAluno = codigoAluno;

                    string codigoMatricula = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codMatricula"].ToString().Replace("MATRI", "") : "0";
                    codigoMatricula = "MATRI" + (int.Parse(codigoMatricula) + 1).ToString().PadLeft(3, '0');
                    aluno.CodMatricula = codigoMatricula;
                    aluno.Curso_codCurso = txtCodCurso.Text;
                    if (aluno.InserirAluno(cod) == true)
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

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskCpf.Text.Length < 11)
            {
               
                    mskCpf.ForeColor = Color.Tomato;

            }
            else
            {
                mskCpf.ForeColor = Color.Black;
            }
        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskTelefone.Text.Length < 11)
            {
                mskTelefone.ForeColor = Color.Tomato;
            }
            else
            {
                mskTelefone.ForeColor = Color.Black;
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
            aluno.EmailDigitado = txtEmail.Text;
            if (aluno.ValidarEmail() == true)
            {
                txtEmail.ForeColor = Color.Red;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;

            }
        }
    }
}
