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
    public partial class frmEditarProf : Form
    {
        string idClicado;
        public frmEditarProf()
        {
            InitializeComponent();
        }
        ClassProfessor prof = new ClassProfessor();

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

            if ((txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") && (txtUsuario.Text != ""))
            {

                prof.Nome = txtNome.Text;
                prof.Telefone = telefoneSemMascara;
                prof.Email = txtEmail.Text;
                prof.Usuario = txtUsuario.Text;


                if (prof.Editar(idClicado) == true)
                {
                    MessageBox.Show("Edição concluida com sucesso.");
                    dgvProf.DataSource = prof.RetProfessor();
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

        private void frmEditarProf_Load(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetProfessor();
        }

        private void dgvProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProf.Rows[e.RowIndex].Cells["codProfessor"].Value.ToString() != "")
            {
                idClicado = (dgvProf.Rows[e.RowIndex].Cells["codProfessor"].Value.ToString());
            }

            txtNome.Text = dgvProf.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvProf.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtUsuario.Text = dgvProf.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            mskTelefone.Text = dgvProf.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetProfessorBusca(txtBusca.Text);
        }
    }
}
