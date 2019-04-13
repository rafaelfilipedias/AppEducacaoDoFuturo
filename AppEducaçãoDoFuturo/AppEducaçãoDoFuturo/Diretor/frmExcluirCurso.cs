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
    public partial class frmExcluirCurso : Form
    {
        string idClicado;
        public frmExcluirCurso()
        {
            InitializeComponent();
        }
        ClassCurso curso = new ClassCurso();
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvCurso.DataSource = curso.RetCursoBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void frmExcluirCurso_Load(object sender, EventArgs e)
        {
            dgvCurso.DataSource = curso.RetCurso();
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString() != "")
            {
                idClicado = (dgvCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString());
            }
            txtCod.Text = dgvCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse curso?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (curso.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvCurso.DataSource = curso.RetCurso();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }
    }
}
