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
    public partial class frmEditarCoordenador : Form
    {
        string idClicado;
        public frmEditarCoordenador()
        {
            InitializeComponent();
        }
        ClassCoordenadorCurso coordenador = new ClassCoordenadorCurso();
        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvCoordenador.DataSource = coordenador.RetCoordenadorBsuca(txtBusca.Text);
        }

        private void frmEditarCoordenador_Load(object sender, EventArgs e)
        {
            dgvCoordenador.DataSource = coordenador.RetCoordenador();
        }

        private void dgvCoordenador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCoordenador.Rows[e.RowIndex].Cells["codCoordenador"].Value.ToString() != "")
            {
                idClicado = (dgvCoordenador.Rows[e.RowIndex].Cells["codCoordenador"].Value.ToString());
            }

            txtNome.Text = dgvCoordenador.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvCoordenador.Rows[e.RowIndex].Cells["email"].Value.ToString();
            mskTelefone.Text = dgvCoordenador.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");


            if ((txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") )
            {

                coordenador.Nome = txtNome.Text;
                coordenador.Telefone = telefoneSemMascara;
                coordenador.Email = txtEmail.Text;
               
                if (coordenador.Editar(idClicado) == true)
                {
                    MessageBox.Show("Edição concluida com sucesso.");
                    dgvCoordenador.DataSource = coordenador.RetCoordenador();
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
