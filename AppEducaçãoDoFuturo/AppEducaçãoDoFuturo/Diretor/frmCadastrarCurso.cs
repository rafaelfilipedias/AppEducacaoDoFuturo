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
    public partial class frmCadastrarCurso : Form
    {
        string codUsuario;
        public frmCadastrarCurso(string codUsuario2)
        {
            codUsuario = codUsuario2;
            InitializeComponent();
        }
        ClassCurso curso = new ClassCurso();
        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            if ((txtConteudo.Text != "") && (txtNome.Text != "") && (txtPlanoAula.Text != "") && (txtPLanoCurso.Text != "") && (txtCodCoordenador.Text != ""))
            {
                curso.ConteudoCurso = txtConteudo.Text;
                curso.Nome = txtNome.Text;
                curso.PlanoDeAula = txtPlanoAula.Text;
                curso.PlanoCurso = txtPLanoCurso.Text;
                curso.CoordenadorCurso_codCoordenador = txtCodCoordenador.Text;
                DataTable dt = curso.RetCurso();

                string codCurso = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codCurso"].ToString().Replace("CUR", "") : "0";
                codCurso = "CUR" + (int.Parse(codCurso) + 1).ToString().PadLeft(3, '0');
                curso.CodCurso = codCurso;
                if (curso.InserirCurso(codUsuario) == true)
                {
                    MessageBox.Show("Registro concluido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Registro não concluido.");
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os dados.");

            }
        }
    }
}
