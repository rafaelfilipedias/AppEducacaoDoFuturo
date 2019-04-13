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
    public partial class frmExcluirDiretor : Form
    {
        string idClicado;
        public frmExcluirDiretor()
        {
            InitializeComponent();
        }
        ClassDiretor diretor = new ClassDiretor();

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvDiretor.DataSource = diretor.RetDiretorBusca(txtBusca.Text);
        }

        private void frmExcluirDiretor_Load(object sender, EventArgs e)
        {
            dgvDiretor.DataSource = diretor.RetDiretor();
        }

        private void dgvDiretor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiretor.Rows[e.RowIndex].Cells["codDiretor"].Value.ToString() != "")
            {
                idClicado = (dgvDiretor.Rows[e.RowIndex].Cells["codDiretor"].Value.ToString());
            }
            txtCod.Text = dgvDiretor.Rows[e.RowIndex].Cells["codDiretor"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse diretor?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (diretor.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvDiretor.DataSource = diretor.RetDiretor();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }
    }
}
