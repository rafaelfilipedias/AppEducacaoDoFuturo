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
    public partial class frmCertificadoMatricula : Form
    {
        public frmCertificadoMatricula()
        {
            InitializeComponent();
        }

        private void frmCertificadoMatricula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEducacaoDoFuturoDataSet.CertificadoMatricula' table. You can move, or remove it, as needed.
            this.CertificadoMatriculaTableAdapter.Fill(this.dbEducacaoDoFuturoDataSet.CertificadoMatricula);

            this.rvMatricula.RefreshReport();
        }
    }
}
