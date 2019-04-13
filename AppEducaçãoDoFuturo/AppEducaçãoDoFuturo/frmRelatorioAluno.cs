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
    public partial class frmRelatorioAluno : Form
    {
        public frmRelatorioAluno()
        {
            InitializeComponent();
        }

        private void frmRelatorioAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEducacaoDoFuturoDataSet.RelatorioAluno' table. You can move, or remove it, as needed.
            this.RelatorioAlunoTableAdapter.Fill(this.dbEducacaoDoFuturoDataSet.RelatorioAluno);

            this.rvAluno.RefreshReport();
        }
    }
}
