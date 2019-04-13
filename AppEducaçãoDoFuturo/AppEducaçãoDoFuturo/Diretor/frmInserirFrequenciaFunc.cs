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
    public partial class frmInserirFrequenciaFunc : Form
    {
        public frmInserirFrequenciaFunc()
        {
            InitializeComponent();
        }
        ClassFrequenciaFunc func = new ClassFrequenciaFunc();
        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                func.Funcionario_codFuncionario = txtCod.Text;
                func.Presenca = DateTime.Now.ToString("yyyy/MM/dd");
                func.AtestadoMedico = Convert.ToDateTime(mskDataAtestado.Text).ToString("yyyy/MM/dd");
                if (func.InserirFrequenciaFunc() == true)
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
