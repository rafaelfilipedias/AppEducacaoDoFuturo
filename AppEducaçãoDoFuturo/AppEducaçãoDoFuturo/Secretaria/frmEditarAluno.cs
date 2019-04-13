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
    public partial class frmEditarAluno : Form
    {
        string idClicado;
        public frmEditarAluno()
        {
            InitializeComponent();
        }
        ClassAluno aluno = new ClassAluno();

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string dataNasSemMascara = mskDataNas.Text.Replace("/", "");

            if (txtBusca.Text != "")
            {
                if ((txtNome.Text != "") && (txtEmail.Text != "") && (dataNasSemMascara != "") && (telefoneSemMascara != "") && (txtCodCurso.Text != ""))
                {

                    aluno.Nome = txtNome.Text;
                    aluno.Telefone = telefoneSemMascara;
                    aluno.Email = txtEmail.Text;
                    aluno.DataNasc = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    aluno.Curso_codCurso = txtCodCurso.Text;

                    if (aluno.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvAluno.DataSource = aluno.RetAluno();
                    }
                    else
                    {
                        MessageBox.Show("Edição não concluída tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os dados.");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo de busca .");
            }
        }

        private void frmEditarAluno_Load(object sender, EventArgs e)
        {
            dgvAluno.DataSource = aluno.RetAluno();
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString() != "")
            {
                idClicado = (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString());
            }

            txtNome.Text = dgvAluno.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvAluno.Rows[e.RowIndex].Cells["email"].Value.ToString();
            mskDataNas.Text = dgvAluno.Rows[e.RowIndex].Cells["dataNasc"].Value.ToString();
            txtCodCurso.Text= dgvAluno.Rows[e.RowIndex].Cells["Curso_codCurso"].Value.ToString();
            mskTelefone.Text = dgvAluno.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvAluno.DataSource = aluno.RetAlunoBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }
    }
}
