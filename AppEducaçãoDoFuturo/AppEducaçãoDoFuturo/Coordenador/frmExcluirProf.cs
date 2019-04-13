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
    public partial class frmExcluirProf : Form
    {
        string idClicado;
        ClassProfessor prof = new ClassProfessor();
        public frmExcluirProf()
        {
            InitializeComponent();
        }

        private void frmExcluirProf_Load(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetProfessor();

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetProfessorBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void dgvProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProf.Rows[e.RowIndex].Cells["codProfessor"].Value.ToString() != "")
            {
                idClicado = (dgvProf.Rows[e.RowIndex].Cells["codProfessor"].Value.ToString());
            }
            txtCod.Text = dgvProf.Rows[e.RowIndex].Cells["codProfessor"].Value.ToString();
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse aluno?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (prof.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvProf.DataSource = prof.RetProfessor();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }
    }
}
