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
    public partial class frmFrequenciaProfessor : Form
    {
        public frmFrequenciaProfessor()
        {
            InitializeComponent();
        }

        private void frmFrequenciaProfessor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEducacaoDoFuturoDataSet.RelatorioProfesor' table. You can move, or remove it, as needed.
            this.RelatorioProfesorTableAdapter.Fill(this.dbEducacaoDoFuturoDataSet.RelatorioProfesor);

            this.rvProfessor.RefreshReport();
        }
    }
}
