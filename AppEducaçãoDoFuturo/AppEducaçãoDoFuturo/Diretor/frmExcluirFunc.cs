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
    public partial class frmExcluirFunc : Form
    {
        string idClicado;
        public frmExcluirFunc()
        {
            InitializeComponent();
        }

        ClassFuncionario func = new ClassFuncionario();
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse funcionário?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (func.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvFunc.DataSource = func.RetFuncionario();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }

        }

        private void frmExcluirFunc_Load(object sender, EventArgs e)
        {
            dgvFunc.DataSource = func.RetFuncionario();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvFunc.DataSource = func.RetFuncionarioBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString() != "")
            {
                idClicado = (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString());
            }
            txtCod.Text = dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString();
        }
    }
}
