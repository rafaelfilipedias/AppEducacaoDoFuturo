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
    public partial class frmTurmaCadastrar : Form
    {
        string cod;
        ClassTurma turma = new ClassTurma();
        public frmTurmaCadastrar(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtNumAlunos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {           
            if ((txtNome.Text != "") && (txtCodProf.Text != "") && (txtNumAlunos.Text!= "") && (txtPontos.Text != ""))
            {                
                    turma.Nome = txtNome.Text;
                    turma.DistribuicaoDePontos = txtPontos.Text;
                    turma.NumAlunos = txtNumAlunos.Text;
                    turma.Professor_codProfessor = txtCodProf.Text;

                    DataTable dt = turma.RetTurma();
                    string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codTurma"].ToString().Replace("TURM", "") : "0";
                    codigo = "TURM" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                    turma.CodTurma = codigo;
                    
                    if (turma.InserirTurma()== true)
                    {
                        MessageBox.Show("Registro concluido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Registro não concluido.Tente novamente.");
                    }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados.");
            }
        }
    }
}
