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
    public partial class frmEditarTurma : Form
    {
        string idClicado;
        ClassTurma turma = new ClassTurma();
        public frmEditarTurma()
        {
            InitializeComponent();
        }

        private void frmEditarTurma_Load(object sender, EventArgs e)
        {
            dgvTurma.DataSource = turma.RetTurma();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvTurma.DataSource = turma.RetTurmaBusca(txtBusca.Text);
        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurma.Rows[e.RowIndex].Cells["codTurma"].Value.ToString() != "")
            {
                idClicado = (dgvTurma.Rows[e.RowIndex].Cells["codTurma"].Value.ToString());
            }

            txtNome.Text = dgvTurma.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtNumAlunos.Text = dgvTurma.Rows[e.RowIndex].Cells["numAlunos"].Value.ToString();
            txtPontos.Text = dgvTurma.Rows[e.RowIndex].Cells["distribuicaoDePontos"].Value.ToString();
            txtCodProf.Text = dgvTurma.Rows[e.RowIndex].Cells["Profesor_codProfessor"].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if ((txtNome.Text != "") && (txtCodProf.Text != "") && (txtNumAlunos.Text != "") && (txtPontos.Text != ""))
            {
                turma.Nome = txtNome.Text;
                turma.NumAlunos = txtNumAlunos.Text;
                turma.DistribuicaoDePontos = txtPontos.Text;
                turma.Professor_codProfessor = txtCodProf.Text;


                if (turma.Editar(idClicado) == true)
                {
                    MessageBox.Show("Edição concluida com sucesso.");
                    dgvTurma.DataSource = turma.RetTurma();
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
    }
}
