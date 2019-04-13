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
    public partial class frmEditarNota : Form
    {
        string idClicado;
        public frmEditarNota()
        {
            InitializeComponent();
        }
        ClassNota nota = new ClassNota();
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvNota.DataSource = nota.RetNotaBusca(txtBusca.Text);
        }

        private void frmEditarNota_Load(object sender, EventArgs e)
        {
            dgvNota.DataSource = nota.RetNota();
        }

        private void dgvNota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNota.Rows[e.RowIndex].Cells["Aluno_codAluno"].Value.ToString() != "")
            {
                idClicado = (dgvNota.Rows[e.RowIndex].Cells["Aluno_codAluno"].Value.ToString());
            }

            txtProva1.Text = dgvNota.Rows[e.RowIndex].Cells["prova1"].Value.ToString();
            txtProva2.Text = dgvNota.Rows[e.RowIndex].Cells["prova2"].Value.ToString();
            txtTrabalho.Text = dgvNota.Rows[e.RowIndex].Cells["trabalho"].Value.ToString();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtProva1.Text != "") && (txtProva2.Text != "") && (txtTrabalho.Text != ""))
            {
               
                nota.Prova1 = float.Parse(txtProva1.Text);
                nota.Prova2 = float.Parse(txtProva2.Text);
                nota.Trabalho = float.Parse(txtTrabalho.Text);

                if (nota.Editar(idClicado) == true)
                {
                    MessageBox.Show("Edição concluida com sucesso.");
                }
                else
                {
                    MessageBox.Show("Edição não concluída.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados!");
            }
        }
    }
}
