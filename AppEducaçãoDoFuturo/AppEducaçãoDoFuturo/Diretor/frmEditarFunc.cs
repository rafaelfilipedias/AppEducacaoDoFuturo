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
    public partial class frmEditarFunc : Form
    {
        ClassFuncionario func = new ClassFuncionario();
        string idClicado;
        public frmEditarFunc()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

            if (txtBusca.Text != "")
            {
                if ((txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") && (txtSenha.Text != ""))
                {

                    func.Nome = txtNome.Text;
                    func.Telefone = telefoneSemMascara;
                    func.Email = txtEmail.Text;
                    func.Senha = txtSenha.Text;
                    func.TipoFunc = cboTipoFuncionario.SelectedIndex + 1;
                  
                    if (func.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvFunc.DataSource = func.RetFuncionario();
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
            else
            {
                MessageBox.Show("Preencha o campo de busca .");
            }
        }

        private void frmEditarFunc_Load(object sender, EventArgs e)
        {
            dgvFunc.DataSource = func.RetFuncionario();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvFunc.DataSource = func.RetFuncionarioBusca(txtBusca.Text);
        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString() != "")
            {
                idClicado = (dgvFunc.Rows[e.RowIndex].Cells["codFuncionario"].Value.ToString());
            }

            txtNome.Text = dgvFunc.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvFunc.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtUsuario.Text= dgvFunc.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            mskTelefone.Text = dgvFunc.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            cboTipoFuncionario.Text= dgvFunc.Rows[e.RowIndex].Cells["tipoFunc"].Value.ToString();
            txtSenha.Text = dgvFunc.Rows[e.RowIndex].Cells["senha"].Value.ToString();
        }
    }
}
