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
    public partial class frmInserirFrequenciaProf : Form
    {
        public frmInserirFrequenciaProf()
        {
            InitializeComponent();
        }
        ClassFrequenciaProf prof = new ClassFrequenciaProf();
        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                prof.Professor_codProfessor = txtCod.Text;
                prof.Presenca = DateTime.Now.ToString("yyyy/MM/dd");
                prof.AtestadoMedico = Convert.ToDateTime(mskDataAtestado.Text).ToString("yyyy/MM/dd");
                if (prof.InserirFrequenciaProf() == true)
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
