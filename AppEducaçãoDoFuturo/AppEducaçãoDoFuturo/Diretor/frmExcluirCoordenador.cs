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
    public partial class frmExcluirCoordenador : Form
    {
        string idClicado;
        public frmExcluirCoordenador()
        {
            InitializeComponent();
        }
        ClassCoordenadorCurso coordenador = new ClassCoordenadorCurso();
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvCoordenador.DataSource = coordenador.RetCoordenadorBsuca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void frmExcluirCoordenador_Load(object sender, EventArgs e)
        {
            dgvCoordenador.DataSource = coordenador.RetCoordenador();
        }

        private void dgvCoordenador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCoordenador.Rows[e.RowIndex].Cells["codCoordenador"].Value.ToString() != "")
            {
                idClicado = (dgvCoordenador.Rows[e.RowIndex].Cells["codCoordenador"].Value.ToString());
            }
            txtCod.Text = dgvCoordenador.Rows[e.RowIndex].Cells["codCoordenador"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse coordenador de curso?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (coordenador.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvCoordenador.DataSource = coordenador.RetCoordenador();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }
    }
}
