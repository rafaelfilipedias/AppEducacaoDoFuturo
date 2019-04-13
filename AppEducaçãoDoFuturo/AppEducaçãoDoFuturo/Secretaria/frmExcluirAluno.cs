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
    public partial class frmExcluirAluno : Form
    {
        string idClicado;
        ClassAluno aluno = new ClassAluno();
        public frmExcluirAluno()
        {
            InitializeComponent();
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

        private void frmExcluirAluno_Load(object sender, EventArgs e)
        {
            dgvAluno.DataSource = aluno.RetAluno();
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString() != "")
            {
                idClicado = (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString());
            }
            txtCod.Text = dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse aluno?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (aluno.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvAluno.DataSource = aluno.RetAluno();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }
    }
}
