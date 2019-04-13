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
    public partial class frmInserirFrequenciaAluno : Form
    {
        string cod;
        public frmInserirFrequenciaAluno(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }
        ClassFrequenciaAluno aluno = new ClassFrequenciaAluno();
        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                aluno.Aluno_codAluno = txtCod.Text;
                aluno.presenca = DateTime.Now.ToString("yyyy/MM/dd");
                if (aluno.InserirFrequenciaAluno(cod) == true)
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
                MessageBox.Show("Preencha todos os dados!");
            }
            
        }
    }
}
