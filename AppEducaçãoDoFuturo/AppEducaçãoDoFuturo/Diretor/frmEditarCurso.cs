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
    public partial class frmEditarCurso : Form
    {
        string idClicado;
        public frmEditarCurso()
        {
            InitializeComponent();
        }
        ClassCurso curso = new ClassCurso();
        private void frmEditarCurso_Load(object sender, EventArgs e)
        {
            dgvCurso.DataSource = curso.RetCurso();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtConteudo.Text != "") && (txtNome.Text != "") && (txtPlanoAula.Text != "") && (txtPLanoCurso.Text != ""))
            {
                curso.ConteudoCurso = txtConteudo.Text;
                curso.Nome = txtNome.Text;
                curso.PlanoDeAula = txtPlanoAula.Text;
                curso.PlanoCurso = txtPLanoCurso.Text;


                if (curso.Editar(idClicado) == true)
                {
                    MessageBox.Show("Edição concluida com sucesso.");
                    dgvCurso.DataSource = curso.RetCurso();
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

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvCurso.DataSource = curso.RetCursoBusca(txtBusca.Text);
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString() != "")
            {
                idClicado = (dgvCurso.Rows[e.RowIndex].Cells["codCurso"].Value.ToString());
            }

            txtNome.Text = dgvCurso.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtPlanoAula.Text = dgvCurso.Rows[e.RowIndex].Cells["planoDeAula"].Value.ToString();
            txtPLanoCurso.Text = dgvCurso.Rows[e.RowIndex].Cells["planoCurso"].Value.ToString();
            txtConteudo.Text = dgvCurso.Rows[e.RowIndex].Cells["conteudoCurso"].Value.ToString();
           
        }
    }
}
