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
    public partial class frmEditarDiretor : Form
    {
        string idClicado;
        ClassDiretor diretor = new ClassDiretor();
        public frmEditarDiretor()
        {
            InitializeComponent();
        }

        private void frmEditarDiretor_Load(object sender, EventArgs e)
        {
            dgvDiretor.DataSource = diretor.RetDiretor();
        }

        private void dgvProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiretor.Rows[e.RowIndex].Cells["codDiretor"].Value.ToString() != "")
            {
                idClicado = (dgvDiretor.Rows[e.RowIndex].Cells["codDiretor"].Value.ToString());
            }

            txtNome.Text = dgvDiretor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvDiretor.Rows[e.RowIndex].Cells["email"].Value.ToString();
            mskTelefone.Text = dgvDiretor.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtUsuario.Text = dgvDiretor.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvDiretor.DataSource = diretor.RetDiretorBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            

            if ((txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "")&& (txtUsuario.Text!=""))
            {

                diretor.Nome = txtNome.Text;
                diretor.Telefone = telefoneSemMascara;
                diretor.Email = txtEmail.Text;
                diretor.Usuario = txtUsuario.Text;
                if (diretor.Editar(idClicado) == true)
                {
                    MessageBox.Show("Edição concluida com sucesso.");
                    dgvDiretor.DataSource = diretor.RetDiretor();
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
