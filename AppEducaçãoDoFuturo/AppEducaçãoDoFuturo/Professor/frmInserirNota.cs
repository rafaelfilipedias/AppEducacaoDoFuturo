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
    public partial class frmInserirNota : Form
    {
        string cod;
        public frmInserirNota(string cod2)
        {
            cod = cod2;
            InitializeComponent();
        }
        ClassNota nota = new ClassNota();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtCod.Text != "")&& (txtProva1.Text!="") && (txtProva2.Text!="") && (txtTrabalho.Text !=""))
            {
                nota.Aluno_codAluno = txtCod.Text;
                nota.Prova1 = float.Parse(txtProva1.Text);
                nota.Prova2 = float.Parse(txtProva2.Text);
                nota.Trabalho = float.Parse(txtTrabalho.Text);

                if (nota.InserirNota(cod) == true)
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
